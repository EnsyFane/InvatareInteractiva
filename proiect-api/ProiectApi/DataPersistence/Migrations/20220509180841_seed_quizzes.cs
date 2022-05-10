using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataPersistence.Migrations
{
    public partial class seed_quizzes : Migration
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
                columns: new[] { "Text", "QuizId" },
                values: new object[,]
                    {
                        {"Cultura organizațională este:","1"},
                        {"Printre beneficiile culturii organizationale NU includem:","1"},
                        {"Cultura care facilitează cel mai puternic activitățile de management al cunoștințelor este:","1"},
                        {"Care din aceste caracteristici generale facilitează un set de activități în ceea ce privește managementul cunoștințelor?","1"},

                        {"Ce atribut nu este specific unui leadership eficient?","2" },
                        {"Care teorie a leadershipului are ca focus conducerea prin exemplu?","2" },
                        {"Conform stilurilor de leadership conturate de Goleman (2017), care este tipul de lider atent la relațiile formate în cadrul echipei și menținerea lor?","2" },

                        {"Cunoștințele tacite sunt:","3" },
                        {"Activitățile de knowledge management nu includ:","3" },
                        {"Unul dintre scopurile liderilor orientați înspre cunoștințe este:","3" },
                        {"Printre factorii care contribuie la succesul managementului cunoștințelor se numără:","3" },

                    }
                );
            migrationBuilder.InsertData(
            table: "Answers",
            columns: new[] { "Text", "IsCorrect", "QuestionId" },
            values: new object[,]
                {
                        {"Modul în care în care o organizație se definește",false,"1"},
                        {"Normele culturale ale unui mediu organizațional",false,"1"},
                        {"Preferințele despre modul de lucru",false,"1"},
                        {"Convingerile și comportamentele împărtășite de membrii organizației",true,"1"},

                        {"loialitatea",false,"2"},
                        {"implicarea față de companie",false,"2"},
                        {"un simț puternic de diversitate",true,"2"},
                        {"sentiment puternic de organizare colectivă",false,"2"},

                        {"cultura axată pe piață",false,"3"},
                        {"cultura adhocrației",true,"3"},
                        {"cultura ierarhică",false,"3"},
                        {"cultura de clan",false,"3"},

                        {"Dezvoltarea unei identități colective puternice",true,"4"},
                        {"Ascunderea de cunoștințe",false,"4"},
                        {"Procese organizationale lipsite de justețe și corectitudine",false,"4"},
                        {"Un nivel ridicat de neîncredere și lipsă de respect",false,"4"},

                        {"Încurajarea muncii din plăcere",false,"5"},
                        {"Modelarea traseului organizației",false,"5"},
                        {"Modelarea unei viziuni proprii impuse asupra celorlalți",true,"5"},
                        {"Găsirea de provocări în realizarea muncii",false,"5"},

                        {"Leadership tranzacțional",true,"6"},
                        {"Leadership transformațional",false,"6"},

                        {"Coercitiv",false,"7"},
                        {"Afiliativ ",true,"7"},
                        {"Coaching",false,"7"},
                        {"Democratic",false,"7"},

                        {"A știi ce",false,"8"},
                        {"Toate cunoștințele pe care o organizație le are la dispoziție",false,"8"},
                        {"Cunoștințele pe care membrii organizației trebuie să le împărtășească mai departe",false,"8"},
                        {"A știi cum",true,"8"},

                        {"Crearea de cunoștințe",false,"9"},
                        {"Ascunderea de cunoștințe",true,"9"},
                        {"Stocarea de cunoștințe",false,"9"},
                        {"Acumularea de cunoștințe ",false,"9"},

                        {"Să încurajeze adoptarea unei culturi pro-învățare care să tolereze greșelile",true,"10"},
                        {"Să întârzie dezvoltarea mecanismelor de transfer, stocare și aplicare a cunoștințelor",false,"10"},
                        {"Să aplice pedepse atunci când angajații nu se angajează în comportamente de management a cunoștințelor",false,"10"},
                        {"Să instituționalizeze învățarea prin eliminarea din organizație a persoanelor care nu aderă la sistemul impus",false,"10"},

                        {"Strategia, leadership-ul pasiv și cultura organizațională",false,"11"},
                        {"Leadership-ul, instrumente IT și măsurarea progresului în managementul cunoștințelor",true,"11"},
                        {"O platformă intranet și conexiune stabilă la internet",false,"11"},
                        {"Inovația și descurajarea greșelilor în munca de zi cu zi",false,"11"},


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

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Modul în care în care o organizație se definește");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Normele culturale ale unui mediu organizațional");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Preferințele despre modul de lucru");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Convingerile și comportamentele împărtășite de membrii organizației");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "loialitatea");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "implicarea față de companie");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "un simț puternic de diversitate");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "sentiment puternic de organizare colectivă");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "cultura axată pe piață");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "cultura adhocrației");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "cultura ierarhică");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "cultura de clan");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Dezvoltarea unei identități colective puternice");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Ascunderea de cunoștințe");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Procese organizationale lipsite de justețe și corectitudine");
            migrationBuilder.DeleteData(
                 table: "Answers",
                 keyColumn: "Text",
                 keyValue: "Un nivel ridicat de neîncredere și lipsă de respect");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Încurajarea muncii din plăcere");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Modelarea traseului organizației");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Modelarea unei viziuni proprii impuse asupra celorlalți");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Găsirea de provocări în realizarea muncii");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Leadership tranzacțional");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Leadership transformațional");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Coercitiv");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Afiliativ");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Coaching");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Democratic");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "A știi ce");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Toate cunoștințele pe care o organizație le are la dispoziție");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Cunoștințele pe care membrii organizației trebuie să le împărtășească mai departe");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "A știi cum");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Crearea de cunoștințe");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Ascunderea de cunoștințe");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Stocarea de cunoștințe");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Acumularea de cunoștințe");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Să încurajeze adoptarea unei culturi pro-învățare care să tolereze greșelile");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Să întârzie dezvoltarea mecanismelor de transfer, stocare și aplicare a cunoștințelor");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Să aplice pedepse atunci când angajații nu se angajează în comportamente de management a cunoștințelor");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Să instituționalizeze învățarea prin eliminarea din organizație a persoanelor care nu aderă la sistemul impus");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Strategia, leadership-ul pasiv și cultura organizațională");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Leadership-ul, instrumente IT și măsurarea progresului în managementul cunoștințelor");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "O platformă intranet și conexiune stabilă la internet");
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Text",
                keyValue: "Inovația și descurajarea greșelilor în munca de zi cu zi");
        }
    }
}
