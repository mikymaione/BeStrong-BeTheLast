﻿/*
MIT License
Copyright (c) 2019: Francesco Dettori, Riccardo Lombardi, Michele Maione
Author: Maione Michele
Contributors:
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;

namespace RandomNameGenerator
{
    public static class NameGenerator
    {

        private static Random _random = new Random(DateTime.Now.Second);

        private static List<string> _ladies = new List<string>
        {
            "AALINA",
            "ABIGAIL",
            "ACHIROPITA",
            "ADA",
            "ADALGISA",
            "ADDOLORATA",
            "ADELAIDE",
            "ADELE",
            "ADELIA",
            "ADELINA",
            "ADIMA",
            "RIANA",
            "AFRA",
            "AGATA",
            "AGNESE",
            "AGOSTINA",
            "AGRIPPINA",
            "AIDA",
            "AIKO",
            "AISHA",
            "ALBA",
            "ALBERTA",
            "ALBINA",
            "ALCESTE",
            "ALDA",
            "ALEANDRA",
            "ALEIDA",
            "ALENA",
            "ALESSANDRA",
            "ALESSIA",
            "ALEXANDRA",
            "ALGISA",
            "ALEXIS",
            "ALIANA",
            "ALICE",
            "ALICIA",
            "ALIDA",
            "ALISEA",
            "ALISEE",
            "ALISSA",
            "ALLEGRA",
            "ALMA",
            "ALTEA",
            "ALICYA",
            "ALLYSON",
            "ALMERINDA",
            "ALYSSA",
            "AMABILE",
            "AMALIA",
            "AMANDA",
            "AMARILLI",
            "AMBA",
            "AMBRA",
            "AMBROSIA",
            "AMELIA",
            "AMELIE",
            "AMINA",
            "AMIRA",
            "ANAGAIA",
            "ANASTASIA",
            "ANCILLA",
            "ANDREINA",
            "ANGELA",
            "ANGELICA",
            "ANGIOLINA",
            "ANIKA",
            "ANITA",
            "ANNA",
            "ANNABELLA",
            "ANNACHIARA",
            "ANNALAURA",
            "ANNALISA",
            "ANNALUNA",
            "ANNAMARIA",
            "ANNARELLA",
            "ANNARITA",
            "ANNAROSA",
            "ANNASOFIA",
            "ANNAVERA",
            "ANNIKA",
            "ANNUNZIATA",
            "ANTEA",
            "ANTIDA",
            "ANTINISKA",
            "ANTONELLA",
            "ANTONIA",
            "ANTONICCA",
            "ANTONIETTA",
            "ANTONINA",
            "ANUSCA",
            "AQUILINA",
            "ARCANGELA",
            "ARIA",
            "ARGENIDE",
            "ARIANNA",
            "ARIANNE",
            "ARIEL",
            "ARIELA",
            "ARIELE",
            "ARLENA",
            "ARMIDA",
            "ARTEMIA",
            "ARTEMIDE",
            "ARTEMISIA",
            "ASCENZA",
            "ASHASA",
            "ASIA",
            "ASMARA",
            "ASSIA",
            "ASSUNTA",
            "ASSUNTA",
            "MARIA",
            "ASTRID",
            "AUGUSTA",
            "AURA",
            "AUREA",
            "AURELIA",
            "AURORA",
            "AZUE",
            "AZZURRA",
            "BARBARA",
            "BEATA",
            "BEATRICE",
            "BELINDA",
            "BELLA",
            "BENEDETTA",
            "BERENICE",
            "BERNADETTE",
            "BERTA",
            "BERTILLA",
            "BETTA",
            "BETTY",
            "BIANCA",
            "BIBIANA",
            "BICE",
            "BONARIA",
            "BONELLA",
            "BRENDA",
            "BRIGIDA",
            "BRIGITTA",
            "BRUNA",
            "BRUNELLA",
            "BRUNETTA",
            "BRUNILDE",
            "CAIDE",
            "CAMILLA",
            "CANDIDA",
            "CARLA",
            "CARLOTTA",
            "CARMELA",
            "CARMEN",
            "CAROLA",
            "CAROLINA",
            "CARTISIA",
            "CASSANDRA",
            "CASSIOPEA",
            "CATERINA",
            "CATIA",
            "CECILIA",
            "CELESTE",
            "CELESTINA",
            "CESIDIA",
            "CESIRA",
            "CHANTAL",
            "CHELSEA",
            "CHIARA",
            "CHIARALUNA",
            "CHRISTINE",
            "CINZIA",
            "CIRA",
            "CLAIRE",
            "CLARA",
            "CLARETTA",
            "CLARITA",
            "CLARISSA",
            "CLAUDIA",
            "CLEA",
            "CLEIDE",
            "CLELIA",
            "CLEMENTINA",
            "CLENEIDE",
            "CLEO",
            "CLEOPATRA",
            "CLEOFE",
            "CLEZIANA",
            "CLEONICE",
            "CLIO",
            "CLODOVEA",
            "CLOE",
            "CLOIDE",
            "CLORINDA",
            "CLOTILDE",
            "COLOMBA",
            "CONCETTA",
            "CONNY",
            "CONNIE",
            "CONSOLATA",
            "CONSUELO",
            "CORINNE",
            "CORNELIA",
            "COSETTA",
            "COSTANZA",
            "CRETA",
            "CRISTEL",
            "CORA",
            "CRISTIANA",
            "CRISTINA",
            "CRISTYN",
            "DAFNE",
            "DAISY",
            "DALIA",
            "DALILA",
            "DAMARIS",
            "DAMIANA",
            "DANA",
            "DANIA",
            "DANIELA",
            "DANILA",
            "DANUSKA",
            "DANUTA",
            "DANZIA",
            "DARIA",
            "DARIELLA",
            "DEA",
            "DEBORA",
            "DEBORAH",
            "DELIA",
            "DELFINA",
            "DELINDA",
            "DEMETRA",
            "DEMETRIA",
            "DEMI",
            "DENISE",
            "DESDEMONA",
            "DESIREE",
            "DESIDERIA",
            "DHARMA",
            "DIAMANTE",
            "DIAMARA",
            "DIANA",
            "DILETTA",
            "DINA",
            "DIOMIRA",
            "DIVA",
            "DOLORES",
            "DOMENICA",
            "DOMEZIA",
            "DOMINIC",
            "DOMITILLA",
            "DOMIZIANA",
            "DONATELLA",
            "DONNA",
            "DORA",
            "DORALICE",
            "DORELLA",
            "DORIS",
            "DORIANA",
            "DORINA",
            "DOROTEA",
            "DOROTY",
            "DRUSIANA",
            "DRUSILLA",
            "EBE",
            "EDDA",
            "EDGARDA",
            "EDI",
            "EDITH",
            "EDNA",
            "EDVIGE",
            "EFREM",
            "EGIZIA",
            "EGLE",
            "ELA",
            "ELAINE",
            "ELBA",
            "ELDA",
            "ELENA",
            "ELENIA",
            "ELEONORA",
            "ELEKTRA",
            "ELETTRA",
            "ELGA",
            "ELIANA",
            "ELIDE",
            "ELISA",
            "ELISABETTA",
            "ELOISA",
            "ELSA",
            "ELTI",
            "ELVA",
            "ELVI",
            "ELVIRA",
            "EMANUELA",
            "EMERENZIANA",
            "EMI",
            "EMILIA",
            "EMMA",
            "EMILY",
            "ENILA",
            "ENOLA",
            "ENORE",
            "ERMELINDA",
            "ENRICHETTA",
            "ERALDA",
            "ERGENIDE",
            "ERICA",
            "ERIKA",
            "ERMELINDA",
            "ERMINIA",
            "ERNESTA",
            "ERSILIA",
            "ERSILDE",
            "ESMERALDA",
            "ESTER",
            "EUFEMIA",
            "EUFRASIA",
            "EUGENIA",
            "EVA",
            "EVELINA",
            "EVELYNE",
            "EVITA",
            "FABIA",
            "FABIANA",
            "FABIOLA",
            "FABRIZIA",
            "FANNY",
            "FATIMA",
            "FAUSTA",
            "FEBE",
            "FEDERICA",
            "FEDORA",
            "FEDRA",
            "FELICIA",
            "FERNANDA",
            "FEMKE",
            "FIAMMA",
            "FIAMMETTA",
            "FILIPPA",
            "FILOMENA",
            "FIONA",
            "FIORDALISA",
            "FIORENZA",
            "FLAMINIA",
            "FLAVIA",
            "FLAVIANA",
            "FLORA",
            "FLORIANA",
            "FLORINDA",
            "FIORELLA",
            "FORTUNA",
            "FORTUNATA",
            "FOSCA",
            "FRANCA",
            "FRANCESCA",
            "FRIDA",
            "FULVIA",
            "FUTURA",
            "GABRIELLA",
            "GAETANA",
            "GAIA",
            "GAVINA",
            "GEA",
            "GELSOMINA",
            "GEMMA",
            "GENESIA",
            "GENEVIEVE",
            "GENNY",
            "GENOVEFFA",
            "GENZIANA",
            "GEORGIANA",
            "GERALDINA",
            "GERARDA",
            "GERMANA",
            "GERTRUD",
            "GERTRUDE",
            "GIACINTA",
            "GIADA",
            "GIAMILA",
            "GIANNA",
            "GIANNINA",
            "GIGLIOLA",
            "GILDA",
            "GINA",
            "GINEVRA",
            "GIOIA",
            "GIORDANA",
            "GIORGIA",
            "GIOVANNA",
            "GIOVITA",
            "GISELLA",
            "GIUDITTA",
            "GIULIA",
            "GIULIANA",
            "GIULIETTA",
            "GIUSEPPINA",
            "GIUSTINA",
            "GIUSY",
            "GLENDA",
            "GLORIA",
            "GRAZIA",
            "GRAZIANA",
            "GRAZIELLA",
            "GRETA",
            "GRISELDA",
            "GUADALUPE",
            "GUENDALINA",
            "GUIA",
            "HALENEY",
            "HEATHER",
            "HEIDE",
            "HELEN",
            "HELENA",
            "HELGA",
            "HELENE",
            "HILARY",
            "HOARA",
            "IAELE",
            "IARA",
            "IDA",
            "IFIGENIA",
            "ILARIA",
            "ILDA",
            "ILEANA",
            "ILENE",
            "ILENIA",
            "IMMACOLATA",
            "INDIA",
            "INES",
            "INGRID",
            "IOLANDA",
            "IOLE",
            "IONIA",
            "IPPOLITA",
            "IRA",
            "IRENE",
            "IRIDEA",
            "IRINA",
            "IRIS",
            "IRMA",
            "ISA",
            "ISABEL",
            "ISABELLA",
            "ISADORA",
            "ISAURA",
            "ISELLA",
            "ISIDE",
            "ISIDORA",
            "ISIRA",
            "ISOTTA",
            "ITALIA",
            "IVA",
            "IVANA",
            "IVANIA",
            "IVONNE",
            "JAMILA",
            "JANA",
            "JANE",
            "JANIRA",
            "JASMINE",
            "JELENA",
            "JENISHA",
            "JENNIFER",
            "JENNY",
            "JESSICA",
            "JILLIAN",
            "JOANNA",
            "JOLE",
            "JOLANDA",
            "JOSEPHINE",
            "JOVANA",
            "JUDITH",
            "JULIA",
            "JUNIA",
            "JUSTINE",
            "KARIN",
            "KATE",
            "KATIA",
            "KATIUSCIA",
            "KATUSCA",
            "KAYLA",
            "KENAN",
            "KENDRA",
            "KETTY",
            "KIRA",
            "KISHA",
            "KRISTEL",
            "KRIZIA",
            "LAIDE",
            "LAILA",
            "LALLA",
            "LARA",
            "LARISSA",
            "LAURA",
            "LAVINIA",
            "LAYLA",
            "LEA",
            "LEDA",
            "LEILA",
            "LELA",
            "LELLA",
            "LEONDINA",
            "LEONILDA",
            "LENA",
            "LETIZIA",
            "LIA",
            "LIANA",
            "LIALA",
            "LIBERA",
            "LICIA",
            "LIDA",
            "LIDIA",
            "LIGEIA",
            "LILIA",
            "LILIANA",
            "LINA",
            "LINDA",
            "LISA",
            "LIVIA",
            "LIVIANA",
            "LJUBA",
            "LOLA",
            "LORA",
            "LOREDANA",
            "LORELAYNE",
            "LORELEY",
            "LORELLA",
            "LORENA",
            "LORENZA",
            "LORETTA",
            "LORIANA",
            "LORITA",
            "LORITY",
            "LORYAN",
            "LUANA",
            "LUCE",
            "LUCETTA",
            "LUCIA",
            "LUCINA",
            "LUCILLA",
            "LUCIANA",
            "LUCREZIA",
            "LUDOVICA",
            "LUIGIA",
            "LUIGINA",
            "LUISA",
            "LUISELLA",
            "LUNA",
            "MADDALENA",
            "MAELA",
            "MAFALDA",
            "MAGDA",
            "MAIA",
            "MAIKA",
            "MAILA",
            "MAIRA",
            "MALVINA",
            "MANILA",
            "MANUELA",
            "MARA",
            "MARCELLA",
            "MAREA",
            "MARELLA",
            "MARETA",
            "MARGARET",
            "MARGHERITA",
            "MARIA",
            "MARIA ADELE",
            "MARIANGELA",
            "MARIA ANTONIETTA",
            "MARIACHIARA",
            "MARIA ASSUNTA",
            "MARIA CARLA",
            "MARIA CLAUDIA",
            "MARIA CONCETTA",
            "MARIACRISTINA",
            "MARIA ELENA",
            "MARIA FLAVIA",
            "MARIAFRANCESCA",
            "MARIAGIORGIA",
            "MARIAGIULIA",
            "MARIAGIOVANNA",
            "MARIAGRAZIA",
            "MARIAITALIA",
            "MARIALAURA",
            "MARIALOURDES",
            "MARIALUCE",
            "MARIALUISA",
            "MARIANEVE",
            "MARIANITA",
            "MARIANELLA",
            "MARIA MADDALENA",
            "MARIANNA",
            "MARIA PAOLA",
            "MARIAPIA",
            "MARIA RITA",
            "MARIAROSA",
            "MARIA SARA",
            "MARIASOLE",
            "MARIATERESA",
            "MARICA",
            "MARIA VITTORIA",
            "MARIELE",
            "MARIELLA",
            "MARIEVA",
            "MARIKA",
            "MARILENA",
            "MARILINA",
            "MARILISA",
            "MARILU'",
            "MARINA",
            "MARINELLA",
            "MARIOLINA",
            "MARISA",
            "MARISEL",
            "MARISOL",
            "MARISSA",
            "MARISTELLA",
            "MARY",
            "MARY",
            "KATE",
            "MARYLIN",
            "MARTA",
            "MARTINA",
            "MARUSKA",
            "MARZIA",
            "MASCHA",
            "MASSIMILIANA",
            "MATILDA",
            "MATILDE",
            "MATTEA",
            "MAUDIA",
            "MAURA",
            "MAURICA",
            "MAYA",
            "MECREN",
            "MELANIA",
            "MELISSA",
            "MELITA",
            "MELITTA",
            "MEGAN",
            "MERCEDES",
            "MIA",
            "MICHELA",
            "MICAELA",
            "MICHELLE",
            "MICOL",
            "MIKOL",
            "MIETTA",
            "MILA",
            "MILENA",
            "MILLY",
            "MILVA",
            "MILVIA",
            "MIRIANA",
            "MINA",
            "MIRANDA",
            "MIRKA",
            "MIREA",
            "MIRELLA",
            "MIRIAM",
            "MIRNA",
            "MIRTA",
            "MIRZIA",
            "MOANA",
            "MOIRA",
            "MONIA",
            "MONIC",
            "MONICA",
            "MOREA",
            "MORENA",
            "MURIELLE",
            "MORGANA",
            "NABILA",
            "NADA",
            "NADIA",
            "NAIKE",
            "NANCY",
            "NAOMI",
            "NARA",
            "NATALIA",
            "NATALINA",
            "NATASCIA",
            "NAUSICA",
            "NAYADE",
            "NEIDE",
            "NELIDA",
            "NELLA",
            "NEREIDE",
            "NERINA",
            "NICHE",
            "NICLA",
            "NICOLE",
            "NICOLETTA",
            "NILDE",
            "NILLA",
            "NINA",
            "NINFA",
            "NIVA",
            "NIVEA",
            "NIVES",
            "NOA",
            "NOELA",
            "NOEMI",
            "NORA",
            "NORIKO",
            "NORMA",
            "NORUENA",
            "NUCCIA",
            "NUMA",
            "NUNZIA",
            "NUVOLETTA",
            "OAKEYSI",
            "ODESSA",
            "OFELIA",
            "OLETTA",
            "OLGA",
            "OLIMPIA",
            "OLIVIA",
            "OMBRETTA",
            "ONESTA",
            "ONORATA",
            "ONORINA",
            "ORETTA",
            "ORIANA",
            "ORIELLA",
            "ORIETTA",
            "ORNELLA",
            "ORSOLA",
            "ORTENSIA",
            "OTTAVIA",
            "PAMELA",
            "PALMA",
            "PALMIRA",
            "PAOLA",
            "PATRIZIA",
            "PENELOPE",
            "PERLA",
            "PERNILLA",
            "PETRA",
            "PHOEBE",
            "PIA",
            "PICCARDA",
            "PIERA",
            "PIERANGELA",
            "PINA",
            "PINUCCIA",
            "PORZIA",
            "PRISCA",
            "PRISCILLA",
            "PROVVIDENZA",
            "PULCHERIA",
            "QUINTINA",
            "QUINZIA",
            "RACHELE",
            "RAFFAELLA",
            "RAIKA",
            "RAISSA",
            "RAMONA",
            "REBECCA",
            "REDENTA",
            "REDIA",
            "REGINA",
            "RENATA",
            "RENZA",
            "RINA",
            "RITA",
            "ROBERTA",
            "ROCCA",
            "ROLITA",
            "ROMANA",
            "ROMINA",
            "ROSA",
            "ROSALBA",
            "ROSALIA",
            "ROSALINDA",
            "ROSAMARIA",
            "ROSANGELA",
            "ROSANNA",
            "ROSARIA",
            "ROSELDA",
            "ROSELINA",
            "ROSELLA",
            "ROSETTA",
            "ROSINA",
            "ROSITA",
            "ROSMARA",
            "ROSMUNDA",
            "ROSSANA",
            "ROSSELLA",
            "ROSY",
            "RUTH",
            "SABINA",
            "SABRINA",
            "SALOME'",
            "SAMANTA",
            "SAMIA",
            "SAMIRA",
            "SAMOA",
            "SANDRA",
            "SANDY",
            "SANTA",
            "SARA",
            "SARAH",
            "SARITA",
            "SASHA",
            "SAVIANA",
            "SEBASTIANA",
            "SEFORA",
            "SELENE",
            "SELVAGGIA",
            "SENIA",
            "SERAFINA",
            "SERENA",
            "SERENELLA",
            "SEVERINA",
            "SHAIRA",
            "SHALABA",
            "SHANA",
            "SHARON",
            "SHEILA",
            "SHIRLEY",
            "SIBILLA",
            "SILVANA",
            "SILVIA",
            "SIMONA",
            "SIRIA",
            "SMERALDA",
            "SMILLA",
            "SOAVE",
            "SOFIA",
            "SOILI",
            "SOLEDAD",
            "SONDRA",
            "SONIA",
            "SORIANA",
            "SOPHIE",
            "SOVIANA",
            "SPERANZA",
            "STEFANIA",
            "STELLA",
            "SUE",
            "SUSANNA",
            "SVEVA",
            "SWAMI",
            "SUELO",
            "TAIDE",
            "TAMARA",
            "TANIA",
            "TARA",
            "TATIANA",
            "TECLA",
            "TEODORA",
            "TERENZIA",
            "TERESA",
            "TERSILLA",
            "TESSA",
            "THEA",
            "TILDE",
            "TINA",
            "TISBE",
            "TIZIANA",
            "TOMMASINA",
            "TONIA",
            "TOSCA",
            "TRISTANA",
            "TULLIA",
            "UBALDA",
            "ULDERICA",
            "ULRICA",
            "UMA",
            "UMBERTA",
            "URSULA",
            "VALENIA",
            "VALENTINA",
            "VALERIA",
            "VANDA",
            "VANESSA",
            "VANIA",
            "VANNA",
            "VELIA",
            "VENERA",
            "VENERE",
            "VENERITA",
            "VERA",
            "VERENA",
            "VERIDIANA",
            "VERONICA",
            "VERUSKA",
            "VESNA",
            "VIENNA",
            "VILIA",
            "VILMA",
            "VINCENZA",
            "VIOLA",
            "VIOLAINE",
            "VIOLANTE",
            "VIOLANTINA",
            "VIOLETTA",
            "VIRGINIA",
            "VIRNA",
            "VITA",
            "VITALBA",
            "VITALIA",
            "VITTORIA",
            "VIVIANA",
            "WANDA",
            "WENDY",
            "WILMA",
            "WINONA",
            "XENA",
            "XENIA",
            "YASMINE",
            "YARA",
            "YLENIA",
            "YOYCE",
            "YVONNE",
            "ZABRY",
            "ZAIRA",
            "ZARA",
            "ZELDA",
            "ZELIA",
            "ZELIDA",
            "ZELINDA",
            "ZEUDI",
            "ZITA",
            "ZOE",
            "ZOIA",
            "ZULEJKA"
        };

        public static string GenerateLadieName()
        {
            return _ladies[_random.Next(0, _ladies.Count)];
        }

    }


}