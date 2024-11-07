using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class MonAn
    {
        [NotMapped]
        private string tenLoaiMonAn;

        public string TenLoaiMonAn { get => tenLoaiMonAn; set => tenLoaiMonAn = value; }
    }
}
