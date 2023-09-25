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

Explain how to use your Unity project. Include any necessary information about controls, settings, or other important aspects of the user experience.

## Licens

Specify the license under which your Unity project is distributed. For example:

This project is licensed under the [License Name] - see the [LICENSE.md](LICENSE.md) file for details.

## Lista över kända buggar

- Bla bla

## Credits

Jag!

## Changelogs

# vr-edutainment-with-bow-and-arrow-basgrupp-1
vr-edutainment-with-bow-and-arrow-basgrupp-1 created by GitHub Classroom

### tips för en annan gång
Om "faces" inte syns från vissa vinklar i unity, efter att ha importat en blender fil, så kan problemet vara "backface culling".

För att kolla/ fixa detta, tryck ned shading fliken, tryck i BackFace Culling (så här ser modellen ut i unity). Om visa faces saknas: Lägg till en solidify modifier till de delar som saknar faces (eventuellt hela modellen).
Kan ibland fixas genom att gå in i "edit-mode" i blender och klicka Ctrl shift N. Ta sedan bort så inside inte är ifyllt under "recalculate normals", spara.
