using Leistungserfassung;
using Leistungserfassung.Data;
using Leistungserfassung.Models;
using Microsoft.Extensions.Configuration;

SampleData obj = SampleData.GetInstance();

var data = obj.GetSampleData();

foreach (var lkos in data)
{
    Console.WriteLine($"ID: {lkos.Id}");
    Console.WriteLine($"DATE: {lkos.DATUMZU}");
    Console.WriteLine($"PKEY: {lkos.PKEY}");
    Console.WriteLine("-----------------------");
}

Leistungskosten lol = new Leistungskosten()
{
    DATUMÄN1 = "14.02.2024",
    
    // [deleted here: USERÄN1, DATUMÄN2, USERÄN2, DATUMÄN3, USERÄN3]
    
    DATUMZU = "14.02.2024",
    USERZU = "SSC",
    STATUS = "3",
    STATUSDATUM = "14.02.2024",
    BEZDATSEG = "C",
    UZ = "NA 4021-01EP",
    SPRSL = "E",
    AUSGDATUM = "14.02.2024",
    GEBONR = "P03F",
    GEBOBEZ = "Erstellung und Bericht Unterlagen aus Parallelakten (IDS) - freiwillig",
    POSTXT = "Complying with national requirements concerning the information on documents known to the applicant; assembling documents from parallel proceedings",
    ABGERPOSKY = "(dbnull)",
    ADRSNR = "100322",
    ANTEIL = "100",
    STATUSUID = "SSC",
    BTRCODEIDBER = "\u00a4E\u00a4E\u00a4",
    IDCODEIDBER = "\u00a4EB\u00a4EB\u00a4",
    ABRCODEIDBER = "\u00a4E06\u00a4E03P\u00a4",
    FAKTORIDBER = "\u00a4E1.0000\u00a4E1.0000\u00a4",
    RGWBTRIDBER = "\u00a4E125.0000\u00a4E50.0000\u00a4",
    FREMDWBTRIDBER = "\u00a4E125.0000\u00a4E50.0000\u00a4",
    OPWBTRIDBER = "\u00a4E125.0000\u00a4E50.0000\u00a4",
    FREMDWSLIDBER = "\u00a4EEUR\u00a4EEUR\u00a4",
    UIDBEAIDBER = "\u00a4EFEG\u00a4ESSC\u00a4",
    
    // [deleted here: MNGIDBER]
    
    OPWÄHRSL = "EUR",
    OPPOSBETRAG = "175",
    
    // [deleted here: ISMUSTERMASKE, ISTZEIT, ISTLEISTUNG, BEAGRUBER, ANSICHTV23LANG, OPKOKY, AUSLFKTIDBER]
    
    RABATTIDBER = "\u00a4E\u00a4E\u00a4",
    PREISSTIDBER = "\u00a4E\u00a4E\u00a4",
    
    // [deleted here: ZTRGICD, KNDCODEBER, ZEITMESSUNGPKEY]
    
    WKURSNACHEUROIDBER = "\u00a4E1.000000\u00a4E1.000000\u00a4",
    WKURSVONEUROIDBER = "\u00a4E1.000000\u00a4E1.000000\u00a4",
    WFAKTORNACHEUROIDBER = "\u00a4E1.0000\u00a4E1.0000\u00a4",
    WFAKTORVONEUROIDBER = "\u00a4E1.0000\u00a4E1.0000\u00a4",
    
    // [deleted here: KNDAKTIVCDBER, NULLABR, GRUID, ANSICHTV20LANG, REDATUM, RENR, COSTINDEX, HINTXT, PROJECT, ISTZEITBEZOGEN]
};

obj.SetSampleData(lol);

Console.WriteLine("\n\nSET NEW DATA\n\n");

// SampleData obj2 = new SampleData();
// SampleData obj3 = new SampleData();

// var data2 = obj2.GetSampleData();
//
// foreach (var lkos in data2)
// {
//     Console.WriteLine($"ID: {lkos.Id}");
//     Console.WriteLine($"DATE: {lkos.DATUMZU}");
//     Console.WriteLine($"PKEY: {lkos.PKEY}");
//     Console.WriteLine($"RABATTIDBER: {lkos.RABATTIDBER}");
//     Console.WriteLine("-----------------------");
// }