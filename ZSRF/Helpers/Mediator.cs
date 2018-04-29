using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSRF.Helpers
{
    static public class Mediator
    {
        static IDictionary<string, List<Action>> noArgs = new Dictionary<string, List<Action>>();
        static IDictionary<string, List<Action<Client>>> dicClient = new Dictionary<string, List<Action<Client>>>();
        static IDictionary<string, List<Action<Service>>> dicService = new Dictionary<string, List<Action<Service>>>();

        #region register
        static public void Register(string token, Action callback)
        {
            if (!noArgs.ContainsKey(token))
            {
                var list = new List<Action>();
                list.Add(callback);
                noArgs.Add(token, list);
            }
            else
            {
                bool found = false;
                foreach (var item in noArgs[token])
                    if (item.Method.ToString() == callback.Method.ToString())
                        found = true;
                if (!found)
                    noArgs[token].Add(callback);
            }
        }
        static public void Register(string token, Action<Client> callback)
        {
            if (!dicClient.ContainsKey(token))
            {
                var list = new List<Action<Client>>();
                list.Add(callback);
                dicClient.Add(token, list);
            }
            else
            {
                bool found = false;
                foreach (var item in dicClient[token])
                {
                    if (item.Method.ToString() == callback.Method.ToString())
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    dicClient[token].Add(callback);
                }
            }
        }
        static public void Register(string token, Action<Service> callback)
        {
            if (!dicService.ContainsKey(token))
            {
                var list = new List<Action<Service>>();
                list.Add(callback);
                dicService.Add(token, list);
            }
            else
            {
                bool found = false;
                foreach (var item in dicService[token])
                {
                    if (item.Method.ToString() == callback.Method.ToString())
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    dicService[token].Add(callback);
                }
            }
        }
        #endregion register

        #region unregister
        static public void Unregister(string token, Action callback)
        {
            if (noArgs.ContainsKey(token))
                noArgs[token].Remove(callback);
        }
        static public void Unregister(string token, Action<Client> callback)
        {
            if (dicClient.ContainsKey(token))
                dicClient[token].Remove(callback);
        }
        static public void Unregister(string token, Action<Service> callback)
        {
            if (dicService.ContainsKey(token))
                dicService[token].Remove(callback);
        }
        #endregion unregister

        #region notifyColleagues
        //static public void NotifyColleagues(string token)
        //{
        //    if (noArgs.ContainsKey(token))
        //    {
        //        foreach (var callback in noArgs[token])
        //        {
        //            callback();
        //        }
        //    }
        //}
        static public void NotifyColleagues(string token, Client args)
        {
            if (dicClient.ContainsKey(token))
            {
                foreach (var callback in dicClient[token])
                {
                    callback(args);
                }
            }
        }
        static public void NotifyColleagues(string token, Service args)
        {
            if (dicService.ContainsKey(token))
            {
                foreach (var callback in dicService[token])
                {
                    callback(args);
                }
            }
        }
        #endregion notifyColleagues

    }
}
