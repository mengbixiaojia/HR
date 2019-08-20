using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAL;
using Model;

namespace DAL
{
    public class config_file_first_kindDAL : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAL
    {
        public int FirstKindAdd(config_file_first_kindModel fk)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id,
                first_kind_id = fk.first_kind_id,
                first_kind_name = fk.first_kind_name,
                first_kind_salary_id = fk.first_kind_salary_id,
                first_kind_sale_id = fk.first_kind_sale_id
            };
            return Add(est);
        }

        public int FirstKindDel(config_file_first_kindModel fk)
        {
            //把DTO转为EO
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id
            };
            return Delete(est);
        }

        public List<config_file_first_kindModel> FirstKindSelect()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel cm = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(cm);
            }
            return list2;
        }

        public config_file_first_kindModel FirstKindSelectBy(int id)
        {
            config_file_first_kind c = SelectBy(e => e.Id.Equals(id)).FirstOrDefault();
            config_file_first_kindModel cm = new config_file_first_kindModel()
            {
                Id=c.Id,
                first_kind_id=c.first_kind_id,
                first_kind_name=c.first_kind_name,
                first_kind_salary_id=c.first_kind_salary_id,
                first_kind_sale_id=c.first_kind_sale_id
            };
            return cm;
        }

        public int FirstKindUpdate(config_file_first_kindModel fk)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = fk.Id,
                first_kind_id = fk.first_kind_id,
                first_kind_sale_id = fk.first_kind_sale_id,
                first_kind_name = fk.first_kind_name,
                first_kind_salary_id = fk.first_kind_salary_id
            };
            return Update(est);
        }
    }
}
