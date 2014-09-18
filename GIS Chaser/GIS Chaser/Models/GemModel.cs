using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;
using System.Web.Security;
using GIS_Chaser.Plumbing.TableInterfaces;


namespace GIS_Chaser.Models
{
    public class GemModel
    {
        private IGemStorage _gemStorage { get; set; }

        public GemModel(IGemStorage gemStorage)
        {
            _gemStorage = gemStorage;
        }

        public List<Gems> GetGemsForUser(string id)
        {
            return _gemStorage.GetAll();
        }

        public void AutoAddGem()
        {
            _gemStorage.Persist(CreateRandomGem());
        }

        public Gems CreateRandomGem()
        {
            return AssembleGem(RandomGemType(), RandomPointValue(), RandomLatitude(286292, 314453), RandomLongitude(742851, 824000));
        }

        public Gems AssembleGem(int type, int points, double latitude, double longitude)
        {
            Gems gem = new Gems { Type = type, PointsValue = points*type, Latitude = latitude, Longitude = longitude };
            return gem;
        }

        private int RandomGemType()
        {
            Random random = new Random();
            return random.Next(1,4);
        }

        private double RandomLatitude(int min, int max )
        {
            Random random = new Random();
            return (double)random.Next(min, max) / 100000 + 41;
        }

        private double RandomLongitude(int min, int max)
        {
            Random random = new Random();
            return (double)random.Next(min, max) / 100000 + 174;
        }

        private int RandomPointValue()
        {
            Random random = new Random();
            return random.Next(10, 25);
        }
    }
}