A projekt egy, az utastájékoztatásban jelentős szerepet betöltő vezérlő, a Vultron fedélzeti vezérlőegység szimulálását végzi el. A valóságban ez a vezérlő végzi az utastájékoztató monitorok, led sorok működtetését, valamint a hangos utastájékoztatást is. A rendszer jelen esetben egy vonatszámokat tartalmazó táblából (Trains) dolgozik, valamint a megfelelő megállókat a Stations táblából olvassa ki a vonatszám alapján. A járatszám és a kocsiszám megadása után kezdődik el az utastájékoztatás.
A vezérlőnek rengeteg speciális típusa van, ebben az esetben a MÁV-START saját gyártású IC+ kocsijaiban használt verziót vettem alapul.

A szoftver indítása után a kezelő választhat a normál menet, vagy a szervíz üzemmód közül. (A szervíz üzemmód nincs szimulálva)
A mód kiválasztása után a rendszer ellenőrzi (szimuláltan) a csatlakoztatott eszközök állapotát, ezután pedig kéri a járatszámot. 
Ha megfelelő járatszám lett megadva, akkor következőleg a kocsiszámot kell megadni. Ha a megadott járatszám nem található, akkor újra kérni fogja a járatszámot. (Ezen a ponton a vezérlő a REPEAT gombbal újraindítható.)
 
A kocsiszám megadása után a járatszámhoz tartozó járatok kiválasztására kerül sor, itt a vasút esetén egy vonatszámhoz egy járat tartozik, így ENTER megnyomásával léphetünk tovább.
 
A következő képernyőn az induló megállót kell kiválasztani (pl. ha csak menet közben kapcsolnánk be az egységet). 
Ezután eljutunk a fő képernyőre, ahol láthatjuk a vonat számát, nemét, a végállomást, a jelenlegi állomást, és a kocsiszámot. Ezen a képernyőn a megállókat tudjuk léptetni a képzeletbeli vonat haladásának megfelelően a fel és le nyilakkal.

A program egy LED mátrix kijelzőt is szimulál, a program indulásakor külön ablakban jelenik meg, kezdetben üresen. Ha a vezérlőn sikeresen eljutunk a fő képernyőre, onnantól aktív a kijelző, és a valósággal közel megegyezően szimulálja a kijelző működését.

Ha eljutottunk a fő képernyőre, akkor lehetőségünk nyílik a kiválaszott vonat főbb adatait egy Excel munkalapra exportálva megtekinteni. Ehhez a D gombot kell megnyomni, ezután automatikusan megnyílik az Excel.