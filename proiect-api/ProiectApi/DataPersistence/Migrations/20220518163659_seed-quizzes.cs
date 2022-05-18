using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataPersistence.Migrations
{
    public partial class seedquizzes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "NoChapter" },
                values: new object[,]
                    {
                        {"1"},
                        {"2"},
                        {"3"}
                    }
                );

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Text", "QuizId", "A", "B", "C", "D", "Answer" },
                values: new object[,] 
                {
                    { "Cultura organizațională este:","1","Modul în care în care o organizație se definește","Normele culturale ale unui mediu organizațional","Preferințele despre modul de lucru","Convingerile și comportamentele împărtășite de membrii organizației","d"},
                    { "Printre beneficiile culturii organizationale NU includem:","1","loialitatea","implicarea față de companie","un simț puternic de diversitate","sentiment puternic de organizare colectivă","c"},
                    { "Cultura care facilitează cel mai puternic activitățile de management al cunoștințelor este:","1","cultura axată pe piață","cultura adhocrației","cultura ierarhică","cultura de clan","b"},
                    { "Care din aceste caracteristici generale facilitează un set de activități în ceea ce privește managementul cunoștințelor?","1","Dezvoltarea unei identități colective puternice","Ascunderea de cunoștințe","Procese organizationale lipsite de justețe și corectitudine","Un nivel ridicat de neîncredere și lipsă de respect","a"},

                    { "Ce atribut nu este specific unui leadership eficient?","2","Încurajarea muncii din plăcere","Modelarea traseului organizației","Modelarea unei viziuni proprii impuse asupra celorlalți","Găsirea de provocări în realizarea muncii","c" },
                    { "Care teorie a leadershipului are ca focus conducerea prin exemplu?","2","Leadership tranzacțional","Leadership transformațional","Leadership charismatic","Leadership participativ","a"},
                    { "Conform stilurilor de leadership conturate de Goleman (2017), care este tipul de lider atent la relațiile formate în cadrul echipei și menținerea lor?","2","Coercitiv","Afiliativ","Coaching","Democratic","b"},

                    { "Cunoștințele tacite sunt:","3","A știi ce","Toate cunoștințele pe care o organizație le are la dispoziție","Cunoștințele pe care membrii organizației trebuie să le împărtășească mai departe","A știi cum","d" },
                    { "Activitățile de knowledge management nu includ:","3","Crearea de cunoștințe","Ascunderea de cunoștințe","Stocarea de cunoștințe","Acumularea de cunoștințe","b" },
                    { "Unul dintre scopurile liderilor orientați înspre cunoștințe este:","3","Să încurajeze adoptarea unei culturi pro-învățare care să tolereze greșelile","Să întârzie dezvoltarea mecanismelor de transfer, stocare și aplicare a cunoștințelor","Să aplice pedepse atunci când angajații nu se angajează în comportamente de management a cunoștințelor","Să instituționalizeze învățarea prin eliminarea din organizație a persoanelor care nu aderă la sistemul impus","a" },
                    { "Printre factorii care contribuie la succesul managementului cunoștințelor se numără:","3","Strategia, leadership-ul pasiv și cultura organizațională","Leadership-ul, instrumente IT și măsurarea progresului în managementul cunoștințelor","O platformă intranet și conexiune stabilă la internet","Inovația și descurajarea greșelilor în munca de zi cu zi","b" },
                }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "NoChapter",
                keyValue: "1");
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "NoChapter",
                keyValue: "2");
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "NoChapter",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Cultura organizațională este:");
            migrationBuilder.DeleteData(
                 table: "Questions",
                 keyColumn: "Text",
                 keyValue: "Printre beneficiile culturii organizationale NU includem:");
            migrationBuilder.DeleteData(
                 table: "Questions",
                 keyColumn: "Text",
                 keyValue: "Cultura care facilitează cel mai puternic activitățile de management al cunoștințelor este:");
            migrationBuilder.DeleteData(
                 table: "Questions",
                 keyColumn: "Text",
                 keyValue: "Care din aceste caracteristici generale facilitează un set de activități în ceea ce privește managementul cunoștințelor ?");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Ce atribut nu este specific unui leadership eficient?");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Care teorie a leadershipului are ca focus conducerea prin exemplu?");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Conform stilurilor de leadership conturate de Goleman (2017), care este tipul de lider atent la relațiile formate în cadrul echipei și menținerea lor?");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Cunoștințele tacite sunt:");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Activitățile de knowledge management nu includ:");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Unul dintre scopurile liderilor orientați înspre cunoștințe este:");
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Text",
                keyValue: "Printre factorii care contribuie la succesul managementului cunoștințelor se numără:");
        }
    }
}
