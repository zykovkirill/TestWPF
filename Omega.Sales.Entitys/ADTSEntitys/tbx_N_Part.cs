using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omega.Sales.Entitys
{
    public class tbx_N_Part
    {
        #region Properties
        public int id { get; set; }
        public string? name { get; set; }
        public string? name_lit { get; set; }
        public string? name_eng { get; set; }
        public int? sale_ratio { get; set; }
        public int? order_ratio { get; set; }
        public decimal? volume { get; set; }
        public decimal? weight { get; set; }
        public decimal? length { get; set; }
        public decimal? height { get; set; }
        public decimal? depth { get; set; }
        public int? id_old { get; set; }
        public int? id_old_db { get; set; }
        public string? comment { get; set; }
        public string? unique_number { get; set; }
        public string? skuba_number { get; set; }
        public Int16? id_status_sys { get; set; }
        public int? id_user_sys { get; set; }
        public int? id_original_sys { get; set; }
        public int? id_db { get; set; }
        public int? id_sess { get; set; }
        public int? id_committed_sys { get; set; }
        public int? id_key { get; set; }
        public string? id_key_joined { get; set; }
        public string? id_key_splitted { get; set; }
        public int? id_prj_root_entity { get; set; }
        public int? id_prj_root_container { get; set; }
        public DateTime? time_edit { get; set; }
        public int? id_main_group { get; set; }
        public int? id_subgroup { get; set; }
        public int? id_main_unit_measure { get; set; }
        public int? id_original_part { get; set; }
        public decimal? gross_weight { get; set; }
        public string? tnved_code { get; set; }
        public string? omega_number { get; set; }
        public string? tnved_code_description { get; set; }
        public bool? use_shelf_life { get; set; }
        public bool? is_sync_1cuat { get; set; }
        #endregion
    }
}
