https://www.nuget.org/packages/OpenIdentity.FluentValidation.Blazor/3.0.0
https://nightbaker.github.io/blazor/fluetvalidator/webassembly/dotnet/2019/11/12/blazor-fluent-validator/
https://fluentvalidation.net/
https://docs.fluentvalidation.net/en/latest/aspnet.html

https://docs.fluentvalidation.net/en/latest/blazor.html

Alt+X
====================================================================
Disable Single Users in Sql Server
1) Restart your Machine
2) Open MSSMS and connect just one time with sa user(or Windows Auth) to db  and create new SQL Page and run the following scrip
-- Start in master
USE MASTER;

-- Add users
ALTER DATABASE [Woorj555304B42405CA2E5BD2454CC54DF6] SET MULTI_USER
GO

====================================================================