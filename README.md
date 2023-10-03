# vr-edutainment-with-bow-and-arrow-basgrupp-1

*Skräp i stora lass* är ett pil och båge spel i VR där man källsorterar olika typer av skräp: plast, metall, papper, kompost och pant. Med hjälp av bågen så spetsar du skräpet med pilen och skjuter den i rätt soptunna. Pant ger dubbla poäng och skuter du skräpet i fel soptunna får du minuspoäng. 

Spelet är riktat mot lågstadieelever. Målet med spelet är att lära sig om vikten av källsortering och återvinning på ett roligt och interaktivt sätt.

## Innehållförteckning

- [Kom Igång](#kom-igång)
  - [Systemkrav](#systemkrav)
  - [Installation](#installation)
- [Användning](#användning)
- [Licens](#licens)
- [Lista över kända fel](#lista-över-kända-buggar)
- [Credits](#credits)
- [Changelogs](#changelogs)

## Kom Igång

Innan du börjar måste du se till att du har rätt program och att du har installerat spelet.

### Systemkrav

- Unity 2021.3.14

### Installation

1. Skapa en ny mapp för ditt projekt
2. Öppna en terminal eller kommandotolk och navigera till den mapp där du vill spara det klonade projektet.
3. Använd `git clone` för att klona projektet:

~~~
git clone https://github.com/abbindustrigymnasium/vr-edutainment-with-bow-and-arrow-basgrupp-1.git
~~~

4. Öppna projektet i Unity

## Användning

### Köra projektet

Vi har använt ett Oculus quest 2 när vi har kört spelet under utvecklingen av spelet. Vi har kört spelet genom att sideloada det och headsetet måste därför vara i developer mode

1. Byt byggplatformen till android.
2. 

### Spela spelet

1. Klicka "Spela" i menyn. Då försvinner menyn och timern startar.
2. Plocka upp pilbågen. En pil kommer att autogenereras på pilbågen när strängen dras i.
3. Spetsa en bit skräp med pilen så att den fastnar.
4. Sikta och skjut skräpet i rätt soptunna. Att skjuta i rätt soptunna ger ett poäng, pant ger två. Men att skjuta i fel soptunna ger minuspoäng.
5. Sortera så mycket skräp som möjligt innan tiden tar slut.
6. Spela igen eller gå tillbaka till menyn.
7. I menyn kan leaderboard ses.

## Licens

Projektet är licensierat under MIT-licens. 

## Lista över kända fel

- Vissa "faces" syns inte från vissa vinklar i Unity, efter att ha importerat en blender fil:
  - Problemet kan vara "backface culling".
  - För att kolla/fixa detta:
    -  inne i blender tryck ned shading fliken
    -  tryck i BackFace Culling (så här ser modellen ut i unity).
    -  Om visa faces saknas: Lägg till en solidify modifier till de delar som saknar faces (eventuellt hela modellen).
  - Kan ibland fixas genom att gå in i "edit-mode" i blender och klicka Ctrl shift N. Ta sedan bort så inside inte är ifyllt under "recalculate normals", spara.
  
- När man bygger projektet för första gången kan Unity klaga på att "Color space" är fel eller inte fungerar som det ska
  - För att lösa detta problem behöver en inställning i player settings ändras. Gå först in i player settings, color space, byt till det andra alternativet (Linear/Gamma). Vi använder Linear, men ibland kan man behöva byta till Gamma och sedan tillbaka till linear.

## Credits

#### Utväcklare:

- Cecilia Ek
- Elvira Tapper
- Emilia Romberg
- Helen Yohanes
- Ängla Törnros

#### Resurser:
- Fist full of shrimp VR Tutorial för pilbåge

## Changelogs

