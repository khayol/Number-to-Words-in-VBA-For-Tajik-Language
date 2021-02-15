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
Forgot Password With SendGrid
KhayolApiKay
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

dotnet add package Sendgrid --version 9.19.0

dotnet user-secrets set SendGridUser KhayolApiKay

dotnet user-secrets set SendGridKey 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

On Windows, Secret Manager stores keys/value pairs in a secrets.json file in the
 C:\Users\khayol.n\AppData\Roaming\Microsoft\UserSecrets\aspnet-Woorj-58B30417-7B72-405C-A2E5-BD2450CC5DF6
 