using Leistungserfassung.Models;
using Microsoft.EntityFrameworkCore;

namespace Leistungserfassung;
using Leistungserfassung.Data;

public class SampleData
{
    private readonly LeistungserfassungContext context;
    public SampleData()
    {
        context = new LeistungserfassungContext();
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
            context.Add(instance);
        }
        context.SaveChanges();
    }
    
    public void SetSampleData(Leistungskosten src)
    {
        context.Add(src);
        context.SaveChanges();
    }
}