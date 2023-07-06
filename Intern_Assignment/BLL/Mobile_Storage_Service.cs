using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
//using AutoMapper;
namespace BLL
{
    public class Mobile_Storage_Service
    {
        public static List<Mobile_Storage_Model> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Mobile_Storage, Mobile_Storage_Model>();    
            });
           var mapper = new Mapper(config);
            var data = mapper.Map<List<Mobile_Storage_Model>>(Product_Repo.Get());
            return data;
        } 

        public static List<string> GetNames()
        {
            var data = Product_Repo.Get().Select(x => x.Name).ToList(); 
            return data;
        }
        public static void Add(Mobile_Storage_Model m1)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Mobile_Storage_Model, Mobile_Storage>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Mobile_Storage>(m1);
            Product_Repo.Add(data);

        }

    }
}
