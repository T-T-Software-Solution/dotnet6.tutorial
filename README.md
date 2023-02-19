# จุดประสงค์
ตั้งใจให้ผู้อ่านได้แนวทางการพัฒนาและดูแล Web API ของเราได้อย่างเหมาะสม ยืดหยุ่น รองรับการเปลี่ยนแปลงที่เกิดขึ้นจากความต้องการของลูกค้า และติดตั้งบน Servers ต่างๆได้อย่างสะดวกนะครับ

เนื้อหาเลยจะไม่ได้เน้นลงลึกในแต่ละหัวข้อ แต่จะรวบรวมหัวข้อที่คิดว่าจำเป็นในการพัฒนา Web API ที่จำเป็นให้ได้มากที่สุดแทนครับผม มองเป็น Keyword ไว้ตามไปศึกษาเพิ่มเติมกันต่อก็ได้นะครับ เย้ ^^

- ติดตั้งโปรแกรมที่จำเป็นกับการพัฒนา Web API ด้วย .NET 

- แนะนำ VS Code Extension เพื่อทำให้การพัฒนา .NET 6 ได้สะดวกขึ้น
- เข้าใจการใช้ .NET CLI ในการจัดการโปรเจ็ค, ฐานข้อมูล และการรันโปรแกรม
- ศึกษาโครงสร้างของไฟล์ใน .NET 6 โปรเจ็ค
- เข้าใจการ Debugging ด้วย VS Code
- เข้าใจแนวทางการพัฒนาโปรเจ็คให้ Source Code มีความยืดหยุ่นและดูแลรักษาได้ง่าย ด้วย - Interface, Dependency Injection, Service Lifetimes, Clean Architecture
- หัดติดตั้งและเชื่อมต่อฐานข้อมูล PostgreSQL ด้วย Docker และ DBeaver
- หัดติดตั้งและเชื่อมต่อฐานข้อมูล MongoDB ด้วย Docker และ MongoDB Compass
- ทดลองใช้ Swagger OpenAPI
- ทดลองใช้งาน Postman ในการเรียก Web API
- ศึกษาเรื่อง IOption Pattern ในการเรียกใช้ Configuration File, Environment Variable
- ทดลองใช้งาน Entity Framework ด้วย Code First Migration, Seeding Data และ Database Context ด้วยการเชื่อมต่อไปที่ PostgreSQL
- ศึกษาเรื่อง Logging ด้วย Serilog และ Sink ด้วยการเชื่อมต่อไปที่ MongoDB
- ศึกษาเรื่อง User Authentication ด้วย .NET Core Identity and JSON Web Tokens
- ศึกษาการทำ Unit Testing ด้วย xUnit
- ทดลองพัฒนา Backgroud/Schedule Process ด้วย Hangfire
- ทดลองสร้างระบบ Health Check UI ด้วย AspNetCore.Diagnostics.HealthChecks
- ปรียบเทียบสิ่งที่ทำไปทั้งหมดในบทความกับ The Twelve Factors App

# บทความที่เกี่ยวข้อง
- [#0: เกริ่นนำ](https://medium.com/@ponggun/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-0-%E0%B9%80%E0%B8%81%E0%B8%A3%E0%B8%B4%E0%B9%88%E0%B8%99%E0%B8%99%E0%B8%B3-a61b277352f9)
- [#1: ติดตั้งโปรแกรม](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-1-%E0%B8%95%E0%B8%B4%E0%B8%94%E0%B8%95%E0%B8%B1%E0%B9%89%E0%B8%87%E0%B9%82%E0%B8%9B%E0%B8%A3%E0%B9%81%E0%B8%81%E0%B8%A3%E0%B8%A1-1ecd8d3bfb66)
- [#2: รวม Cheat Sheet](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-2-%E0%B8%A3%E0%B8%A7%E0%B8%A1-cheat-sheet-cb696ffb3eba)
- [#3: Empty Solution in GitHub](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-3-empty-solution-in-github-a6313b12d741)
- [#4: พัฒนาโครงสร้างของ Source Code](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-4-%E0%B8%9E%E0%B8%B1%E0%B8%92%E0%B8%99%E0%B8%B2%E0%B9%82%E0%B8%84%E0%B8%A3%E0%B8%87%E0%B8%AA%E0%B8%A3%E0%B9%89%E0%B8%B2%E0%B8%87%E0%B8%82%E0%B8%AD%E0%B8%87-source-code-8269f8dfb6f6)
- [#5: VS Code Debugging](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-5-vs-code-debugging-ff10c3abda17)
- [#6: Configuration](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-6-configuration-6ca0086971bc)
- [#7: Dependency Injection & Service Lifetime](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-7-dependency-injection-service-lifetime-c04f83324c8b)
- [#8: Domain Project](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-8-domain-project-11563b7420b5)
- [#9: Core Project](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-9-core-project-36c41b429acb)
- [#10: Infra Project](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-10-infra-project-entity-framework-315abe158f5f)
- [#11: API Project](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-11-api-project-72bad7acb16b)
- [#12: Unit Testing](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-12-unit-testing-6db7e6a8f6da)
- [#13: Logging and Monitoring](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-13-logging-and-monitoring-96b92a74b92e)
- [#14:เพิ่มความปลอดภัยด้วย OAuth2 & OpenID Connect](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-14-%E0%B9%80%E0%B8%9E%E0%B8%B4%E0%B9%88%E0%B8%A1%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%9B%E0%B8%A5%E0%B8%AD%E0%B8%94%E0%B8%A0%E0%B8%B1%E0%B8%A2%E0%B8%94%E0%B9%89%E0%B8%A7%E0%B8%A2-oauth2-openid-connect-134eca166d76)
- [#15: Background Process & Scheduler](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-15-background-process-scheduler-8dfcf1d65857)
- [#16: Health Checks](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-16-health-checks-daa56cf25fd8)
- [#17: The Twelve-Factor App](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-17-the-twelve-factor-app-539b30702899)
- [#18: Deployment — Docker](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-18-deployment-docker-98531b3a6984)
- [#19: Deployment — Azure App Service](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-19-deployment-azure-app-service-6379ac605596)
- [#20: Deployment — Azure Container Apps](https://ponggun.medium.com/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-20-deployment-azure-container-apps-5ad97fc7a4fb)