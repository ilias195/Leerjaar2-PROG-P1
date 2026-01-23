# Leerjaar2-PROG-P1

## les 1 Herhaling Functions, Classes en Arrays

### Opdracht 1A BallSpawner
![Opdr1A Ball](https://github.com/user-attachments/assets/6d6f9737-d4a9-4c36-8e5d-dc258343f37f)

in Deze gifje kun je zien dat er kleurrijke ballen in de scène spawnen op willekeurige posities. Bij het starten van het spel verschijnen er meteen 100 ballen, en daarna verschijnt er elke seconde een nieuwe bal. Elke bal verdwijnt automatisch na 3 seconden.

[Klik hier voor de scripts](https://github.com/ilias195/Leerjaar2-PROG-P1/tree/main/Assets/Scripts/Les01Functions%2C%20Classes%20en%20Arrays)

### Opdracht 1B TowerSpawner
![Les1-B TowerSpawner](https://github.com/user-attachments/assets/550d3b22-47f2-44af-bac7-b1f16815e88e)

In deze opdracht kan je met de Linker Mousbutton Towers laten Spawnen op verschillende posities en verschillende grotes.

### Hoe heb ik het aangepakt?
ik heb een Script aangemaakt genaamd TowerSpawner. Vervolgens heb ik van de Tower een prefab gemaakt en in mijn Script een leeg Gameobject.
Hierdoor kan ik mijn Prefab slepen in het leeg Gamobject in Unity, zodat de Towers Random in Spawnen in mijn game en niet al in mijn Hierachry zitten. Daarnaast heb
ik gezegd in mijn code maak een kopie van die prefab zet het in mijn Scene. Ten slot heb ik een positie en een Scale meegeven die Random moet zijn met 0 Rotatie.

[Bekijk hier mijn Script voor de TowerSpawner](https://github.com/ilias195/Leerjaar2-PROG-P1/tree/main/Assets/Scripts/Les01Functions%2C%20Classes%20en%20Arrays/OpdrB-TowerSpawner)

### Opdracht 1C EnemiesSpawner
![Opdr 1C](https://github.com/user-attachments/assets/5b7f3590-5b17-440a-acb6-550748d682a3)

in deze gifje kun je zien dat de enemies worden ingespawnt na 3 seconden. Daarnaast kan je met key (W) 100 enmies laten in spawnen in de game. Ook kan je wanneer je alles weg wilt halen dat word de Destroy aangeroepen en dat kan je met de key (Q) doen.

[klik hier voor de scripts](https://github.com/ilias195/Leerjaar2-PROG-P1/tree/main/Assets/Scripts/Les01Functions%2C%20Classes%20en%20Arrays)


## les 2 Action events 
![les2ActionEvents(10Mb)](https://github.com/user-attachments/assets/7695a7da-0301-43ef-b68b-fdb45c8da477)

### PlayerMovement
in deze gifje kan je zien dat ik een playerMovement heb gemaakt wat je kan besturen
met WSAD. Vervolgens heb ik ook de Camara in de player gezet zodat de Camara de player volgt.

### PickUpsystem 
ik heb ook een PickUpSystem gemaakt. Die objecten triggeren door een Collider die vervolgens de
speler kan opakken en bij het oppakken word er score bij opgeteld en word het Object verwijderd.

### ScoreBoard
Ten slot heb ik een Scoreboard gemaakt waar de score word opgeteld van de Objecten die opgepakt zijn. 
en die Score word bijgehouden in de UI TextMesh pro.

[bekijk hier mijn Scripts](https://github.com/ilias195/Leerjaar2-PROG-P1/tree/main/Assets/Scripts/les2ActionEvents)

## 


## les 4 Single Responsibility (SRP) en Don't Repeat Yourself (DRY)

### Opdracht 1A SRP
![les4-Dry-SRP-4a](https://github.com/user-attachments/assets/5aea65f4-98e3-4c88-9916-134286cdf9fc)

In deze opdracht hebben we het originele script "**ShipBehaviour**" opgesplitst op  het Single Responsibility Principle (SRP) manier. 
Elk onderdeel van het schip heeft nu een eigen script met één duidelijke taak, zoals bewegen, schieten, inventory en UI.

### Hoe heb ik het aangepakt ?

We hebben eerst bepaald welke taken in ShipBehaviour zaten en deze verdeeld over meerdere scripts 
(ShipMovement, ShipShooting, ShipInventory, ShipUI).
Vervolgens heb ik de scripts met elkaar laten communiceren via publieke methodes, zodat de schip nog hetzelfde blijft werken
maar de code overzichtelijker en beter uitbreidbaar is.

[Bekijk hier mijn Scripts hoe ik het heb gedaan](https://github.com/ilias195/Space48-p1OPDR4-/tree/main/Assets/Scripts)

