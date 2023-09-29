# vr-edutainment-with-bow-and-arrow-basgrupp-1

*Skräp i stora lass* är ett pil och båge spel i VR där man källsorterar olika typer av skräp: plast, metall, papper, kompost och pant. Med hjälp av bågen så spetsar du skräpet med pilen och skjuter den i rätt soptunna. Pant ger dubbla poäng och skuter du skräpet i fel soptunna får du minuspoäng. 

## Innehållförteckning

- [Kom Igång](#kom-igång)
  - [Systemkrav](#systemkrav)
  - [Installation](#installation)
- [Användning](#användning)
- [Licens](#licens)
- [Lista över kända buggar](#lista-över-kända-buggar)
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

1. Plocka upp pilbågen. En pil kommer att autogenereras på pilbågen.
2. Spetsa en bit skräp med pilen så att den fastnar.
3. Skjut pilen i rätt soptunna.
4. Sortera så mycket skräp som möjligt innan tiden tar slut.

## Licens

Projektet är licensierat under MIT-licens. 

## Lista över kända buggar

- Vissa "faces" syns inte från vissa vinklar i Unity, efter att ha importerat en blender fil:
  - Problemet kan vara "backface culling".
  - För att kolla/fixa detta:
    -  inne i blender tryck ned shading fliken
    -  tryck i BackFace Culling (så här ser modellen ut i unity).
    -  Om visa faces saknas: Lägg till en solidify modifier till de delar som saknar faces (eventuellt hela modellen).
  - Kan ibland fixas genom att gå in i "edit-mode" i blender och klicka Ctrl shift N. Ta sedan bort så inside inte är ifyllt under "recalculate normals", spara.

## Credits

#### Utväcklare:

- Cecilia Ek
- Elvira Tapper
- Emilia Romberg
- Helen Yohanes
- Ängla Törnros

#### Resurser:
- Fist full of shrimp

## Changelogs

