using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ClientApp.Models;

public class Helper
{
    public static string? GetName(Country? country)
    {
        if (country?.Name?.NativeName?.Ara != null)
        {
            return country.Name.NativeName.Ara.Common;
        }

        if (country?.Name?.NativeName?.Bre != null)
        {
            return country.Name.NativeName.Bre.Common;
        }

        if (country?.Name?.NativeName?.Ces != null)
        {
            return country.Name.NativeName.Ces.Common;
        } 
        
        if (country?.Name?.NativeName?.Cym != null)
        {
            return country.Name.NativeName.Cym.Common;;
        }
        if (country?.Name?.NativeName?.Deu != null)
        {
            return country.Name.NativeName.Deu.Common;;
        } 
        if (country?.Name?.NativeName?.Est != null)
        {
            return country.Name.NativeName.Est.Common;;
        }
        if (country?.Name?.NativeName?.Eng != null)
        {
            return country.Name.NativeName.Eng.Common;;
        }
        
        if (country?.Name?.NativeName?.Fin != null)
        {
            return country.Name.NativeName.Fin.Common;;
        }
        if (country?.Name?.NativeName?.Fra != null)
        {
            return country.Name.NativeName.Fra.Common;;
        } 
        if (country?.Name?.NativeName?.Hrv != null)
        {
            return country.Name.NativeName.Hrv.Common;;
        }
        if (country?.Name?.NativeName?.Hun != null)
        {
            return country.Name.NativeName.Hun.Common;;
        } 
        if (country?.Name?.NativeName?.Ita != null)
        {
            return country.Name.NativeName.Ita.Common;
            
        }
        if (country?.Name?.NativeName?.Jpn != null)
        {
            return country.Name.NativeName.Jpn.Common;;
        } 
        if (country?.Name?.NativeName?.Kor != null)
        {
            return country.Name.NativeName.Kor.Common;;
        }
        if (country?.Name?.NativeName?.Nld != null)
        {
            return country.Name.NativeName.Nld.Common;;
        } 
        if (country?.Name?.NativeName?.Per != null)
        {
            return country.Name.NativeName.Per.Common;;
        } 
        if (country?.Name?.NativeName?.Por != null)
        {
            return country.Name.NativeName.Por.Common;;
        } 
        if (country?.Name?.NativeName?.Rus != null)
        {
            return country.Name.NativeName.Rus.Common;;
        } 
        if (country?.Name?.NativeName?.Slk != null)
        {
            return country.Name.NativeName.Slk.Common;;
        } if (country?.Name?.NativeName?.Spa != null)
        {
            return country.Name.NativeName.Spa.Common;;
        } 
        if (country?.Name?.NativeName?.Swe != null)
        {
            return country.Name.NativeName.Swe.Common;;
        } 
        if (country?.Name?.NativeName?.Tur != null)
        {
            return country.Name.NativeName.Tur.Common;;
        } if (country?.Name?.NativeName?.Urd != null)
        {
            return country.Name.NativeName.Tur?.Common;;
        } if (country?.Name?.NativeName?.Zho != null)
        {
            return country.Name.NativeName.Zho.Common;;
        }
        if (country?.Name?.NativeName?.Msa != null)
        {
            return country.Name.NativeName.Msa.Common;;
        }
        if (country?.Name?.NativeName?.Sqi != null)
        {
            return country.Name.NativeName.Sqi.Common;;
        }
        if (country?.Name?.NativeName?.Sin != null)
        {
            return country.Name.NativeName.Sin.Common;;
        }
        if (country?.Name?.NativeName?.Bul != null)
        {
            return country.Name.NativeName.Bul.Common;;
        }
        
        if (country?.Name?.NativeName?.Srp != null)
        {
            return country.Name.NativeName.Srp.Common;;
        }
        if (country?.Name?.NativeName?.Kat != null)
        {
            return country.Name.NativeName.Kat.Common;;
        }
        if (country?.Name?.NativeName?.Nor != null)
        {
            return country.Name.NativeName.Nor.Common;;
        }
        if (country?.Name?.NativeName?.Dzo != null)
        {
            return country.Name.NativeName.Dzo.Common;;
        }
        if (country?.Name?.NativeName?.Ron != null)
        {
            return country.Name.NativeName.Ron.Common;;
        }
        if (country?.Name?.NativeName?.Lao != null)
        {
            return country.Name.NativeName.Lao.Common;;
        }
        if (country?.Name?.NativeName?.Slv != null)
        {
            return country.Name.NativeName.Slv.Common;;
        }
        
        if (country?.Name?.NativeName?.Lav != null)
        {
            return country.Name.NativeName.Lav.Common;;
        }
        
        if (country?.Name?.NativeName?.Tha != null)
        {
            return country.Name.NativeName.Tha.Common;;
        }
        if (country?.Name?.NativeName?.Ell != null)
        {
            return country.Name.NativeName.Ell.Common;;
        }
        if (country?.Name?.NativeName?.Dan != null)
        {
            return country.Name.NativeName.Dan.Common;;
        }
        if (country?.Name?.NativeName?.Amh != null)
        {
            return country.Name.NativeName.Amh.Common;;
        }
        if (country?.Name?.NativeName?.Mya != null)
        {
            return country.Name.NativeName.Mya.Common;;
        }
        if (country?.Name?.NativeName?.Ind != null)
        {
            return country.Name.NativeName.Ind.Common;;
        }
        if (country?.Name?.NativeName?.Div != null)
        {
            return country.Name.NativeName.Div.Common;;
        }
        if (country?.Name?.NativeName?.Kal != null)
        {
            return country.Name.NativeName.Kal.Common;;
        }
        if (country?.Name?.NativeName?.Pol != null)
        {
            return country.Name.NativeName.Pol.Common;;
        }
        if (country?.Name?.NativeName?.Nno != null)
        {
            return country.Name.NativeName.Nno.Common;;
        }
        if (country?.Name?.NativeName?.Isl != null)
        {
            return country.Name.NativeName.Isl.Common;;
        }
        if (country?.Name?.NativeName?.Nep != null)
        {
            return country.Name.NativeName.Nep.Common;;
        }
        if (country?.Name?.NativeName?.Ben != null)
        {
            return country.Name.NativeName.Ben.Common;;
        }
        if (country?.Name?.NativeName?.Khm != null)
        {
            return country.Name.NativeName.Khm.Common;;
        }
        if (country?.Name?.NativeName?.Cnr != null)
        {
            return country.Name.NativeName.Cnr.Common;;
        }
        if (country?.Name?.NativeName?.Ukr != null)
        {
            return country.Name.NativeName.Ukr.Common;;
        }
        if (country?.Name?.NativeName?.Prs != null)
        {
            return country.Name.NativeName.Prs.Common;;
        }
        if (country?.Name?.NativeName?.Cat != null)
        {
            return country.Name.NativeName.Cat.Common;;
        }
        if (country?.Name?.NativeName?.Mon != null)
        {
            return country.Name.NativeName.Mon.Common;;
        }
        if (country?.Name?.NativeName?.Hye != null)
        {
            return country.Name.NativeName.Hye.Common;;
        }
        if (country?.Name?.NativeName?.Lit != null)
        {
            return country.Name.NativeName.Lit.Common;;
        }
        if (country?.Name?.NativeName?.Mkd != null)
        {
            return country.Name.NativeName.Mkd.Common;;
        }
        if (country?.Name?.NativeName?.Vie != null)
        {
            return country.Name.NativeName.Vie.Common;;
        }
        if (country?.Name?.NativeName?.Bar != null)
        {
            return country.Name.NativeName.Bar.Common;;
        }
        if (country?.Name?.NativeName?.Fas != null)
        {
            return country.Name.NativeName.Fas.Common;;
        }
        else
        {
            return "";
        }
    }
}