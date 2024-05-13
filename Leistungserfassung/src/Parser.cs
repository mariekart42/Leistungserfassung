namespace Leistungserfassung;

public class Parser
{
    public Parser()
    {
        
    }

    /* RABATTIDBER ist ein Eintrag, welcher in Kullerbereichen geschrieben,
     * angiebt ob es sich um Eigen- (E) oder Fremdhonorar (F) handelt.
     * Für diese Applikation muss RABATTIDBER immer 'E' sein. */
    public void IsEigenhonorar(string rabattidber)
    {
        // parse the Field with RABATTIDBER and check if bea starts with E
        // could be like this: ¤EFEG¤EGER¤ [YES], ¤EGER¤ [NO], ¤EFEG¤FGER¤ [YES]
    }
    
}