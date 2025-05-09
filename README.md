---
author: Lektion 12
date: MMMM dd, YYYY
paging: "%d / %d"
---

# Lektion 12

Hej och välkommen!

## Dagens agenda

1. Frågor och repetition
2. Övning i säkerhet
3. Introduktion till Identity Core
4. Övning med handledning

---

# Gruppövning

Bygg en väldigt enkel todo applikation med endast controllers som sparar data till in-memory listor eller databas. Man skall kunna:

- Skapa användare
- Skapa todo som kopplas till användare

Fundera på, och försök implementera, säkerhet för applikationen:

- Hur förhindar man en användare från att komma åt en annan användares data?
- Hur kan autentisering hanteras?
- Hur skyddas känslig information?

---

# Introduktion till webbsäkerhet

- Skydda användardata
- Håll kommunikation hemlig
- Förhindra otillåten åtkomst
- Håll servers uppe
- Tänk i form av hot/attacker
- Utveckling och säkerhet är alltid en balans mellan UX och säkerhet

---

# Krypterad kommunikation

- Använd HTTPS och inte bara HTTP
- Besök endast webbsidor med HTTP
- Konfigurera HTTPS-only i webbläsare

---

# Autentisering

- Identifiering av användare
- Användarsystem med namn och lösenord
- Inloggning
- Cookies och tokens

# Auktorisering

- Tillgång till resurser
- Bygger på autentisering
- Roles, permissions, authorities

---

# Cookies

- Data som lagras i webbläsaren
- Skickas med till server varje anrop
- Brukar användas för att lagra tokens och hantera autentisering
- Kan utsättas för CSRF-attacker

---

# Tokens och JWT

- En hemlig sträng för identifiering
- Krypterad och kan innehålla information

---

# CORS (Cross Origin Resource Sharing)

- Tillhör SOP, Same Origin Policy
- HTTP-header baserad säkerhet
- Bestämmer var server kan anropas ifrån

---

# Introduktion till Identity Core

- Tillägg till ASP.NET som implementerar användarsystem
- Hanterar registrering, inlogg, tokens, roller m.m
- Hanterar auktorisering med roller
- Installera: `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore`
