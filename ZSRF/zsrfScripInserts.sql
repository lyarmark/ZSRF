use zsrf
go
insert into client
(clastname, cfirstname, caddress, ccity, cstate, czip, ccountry, cphone,
cage, cdob, cemail, ccellphone, cdiagnosis, creferlast, creferfirst,
creferrelation, creferaddress, crefercity, creferstate, creferzip, creferphone, crefcell,
cdoctorname, cdoctoraddress, cdoctorphone, chospital, cmemo)
values
('doe', 'jane', '123 main street', 'anytown', 'YZ', '12345', 'USA', '8005555555',
21, '1/1/1996', 'janedoe@gmail.com', '8005550000', 'anyDiagnosis', 'doe', 'john',
'brother', '123 main street', 'anytown', 'YZ', '12345', '8005551111', '805552222',
'dr', '321 main street', '8005553333', 'anyHospital', 'memo')

--select * from client


insert into service
(clientid, servicetype, servicedate, serviceCheckNum, serviceamnt, memo, notes)
values
(2, 'anyservice', getdate(), 101, 100.0, 'memo', 'notes')

--select * from service
