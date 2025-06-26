# Azure Appservice
* Fully managed platform as as service (Paas)
* Key benefits:
  - fully managed 
  - Auto scaling
  - High availability 
  - Security 
  - Devops Integration
  - Global Scale

---

## Azure App Service Plans
* defines the computer resources and the pricing category
* components :
   - region
   - operating system
   - pricing tier
   - instance count 

### pricing Tier beakdown
* Free(F1) : 1GB, shared CPU,  no(custom domain, ssl, auto scale, deployment slots), development, testing , proof of concept
* shared(D1) :1GB,  shared CPU,   custom domain, no(ssl, auto scale, deployment slots), small personal website
* Basic(B1-3) : 10GB, Dedicated CPU,  custom domain, manual scaling , ssl,  no(auto scale, deployment slots), small prod env, dev env
* Standard(S1-3): 50GB, Dedicated CPU, custom domain, manual scaling , ssl, auto scale(10), deployment slots(5), prod,moderate traffic
* premium(p1v1- 3v3): 250gb, Fater CPU, custom domain, manual scaling , ssl, auto scale(30), deployment slots(20), VNET, high perf app
* isolated : ITB, dedicated env, All premium features, mission critical apps


### Chosing the right tier 
consider these factors
1. traffic volume
2. perfomance requirement
3. high avaliability
4. secruity 
5. budget
6. scaling

---

## Application setting vs Connection Strings
* App settings: stores app configuration value ; e.g api keys, feature flags etc ; can be marked as slot settings
* connection string : stores database values ; encypted at rest; use key valut reference for sensitive data
@Microsoft.KeyVault(SecretUri=https://myvault.vault.azure.net/secrets/mysecret/)

### Configuration Sources (Priority Order)
Command-line arguments (highest priority)
Environment variables (App Settings in Azure)
User secrets (development only)
appsettings.{Environment}.json
appsettings.json (lowest priority)

---

## Scaling strategies
* vertical scaling : scale up/down
* horizontal scaling : scale in / out;  manual scaling; auto scaling
  - auto scaling : rule based -- triggers(CPU %, memory %, request count, queue length, custom metrics)


---

## Hands on Labs
### Lab1:deployment methods and strategies
* local git deployment : basic auth
* github/azure devops : ci/cd; oauth
* zip deploy 
* ftp/ftps
* arm templates
* container deployment


#### Lab1a deploy via local git

```bash


