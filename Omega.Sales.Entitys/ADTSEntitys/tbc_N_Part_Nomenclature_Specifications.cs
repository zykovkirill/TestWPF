using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omega.Sales.Entitys
{
	public class tbc_N_Part_Nomenclature_Specifications
	{
		public int id { get; set; }
		public int? id_part { get; set; }
		public int? id_nomenclature_specifications { get; set; }
		public short? id_status_sys { get; set; }
		public int? id_original_sys { get; set; }
		public int? id_committed_sys { get; set; }
		public int? id_sess { get; set; }
		public DateTime? time_edit { get; set; }

	}
}