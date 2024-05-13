using Leistungserfassung.Models;
using Microsoft.EntityFrameworkCore;

namespace Leistungserfassung;
using Leistungserfassung.Data;

/*
 * This Class follows the Singleton Pattern.
 * Because we want to mak sure, that context only gets created
 * a single time in the whole application, this class will only create
 * on instance of itself.
 * Creating a second instance of this class will result in receiving
 * the instance created during first call of class.
 */
// sealed: can't be inherited
public sealed class SampleData
{
    private static SampleData _instance;
    private readonly LeistungserfassungContext context;
    
    // private Constructor -> can only be used inside of the class
    private SampleData()
    {
        context = new LeistungserfassungContext();
    }
    public static SampleData GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SampleData();
        }
        return _instance;
    }
    
    public List<Leistungskosten> GetSampleData()
    {
        var data = context.Lkos;
        return data.ToList();
    }

    public void SetSampleData(List<Leistungskosten> src)
    {
        foreach (var instance in src)
        {
            instance.PKEY = instance.Id.ToString();
            context.Add(instance);
        }
        context.SaveChanges();
    }
    
    public void SetSampleData(Leistungskosten src)
    {
        src.PKEY = src.Id.ToString();
        context.Add(src);
        context.SaveChanges();
    }
}