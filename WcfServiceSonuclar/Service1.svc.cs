using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceSonuclar
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SinavSonuclariEntities sonuclariEntities = new SinavSonuclariEntities();
        public List<Ogrenciler> GetOgrencilers()
        {
            return (from o in sonuclariEntities.Ogrenciler select o).ToList();
        }

        public List<Turler> GetTurlers()
        {
            return (from t in sonuclariEntities.Turler select t).ToList();
        }

        public List<Yillar> GetYillars()
        {
            return (from y in sonuclariEntities.Yillar select y).ToList();
        }

        public Sonuclar GetSonuclar(int ogrenciId, int turId, int yilId)
        {
            return (
                      from s in sonuclariEntities.Sonuclar
                      where s.OgrenciId == ogrenciId
                            && s.TurId == turId
                            && s.YilId == yilId
                      select s
                    ).FirstOrDefault();
        }
    }
}