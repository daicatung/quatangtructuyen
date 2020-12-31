using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailsProduct_DTO
    {
        int ProductID_;
        string Description_, Title_, Photo_, Tit1_, Tit2_, Tit3_, Tit4_, Tit5_;
        string Des1_, Des2_, Des3_, Des4_, Des5_;
        string Photo1_, Photo2_, Photo3_, Photo4_, Photo5_;

        public int ProductID { get => ProductID_; set => ProductID_ = value; }
        public string Description { get => Description_; set => Description_ = value; }
        public string Title { get => Title_; set => Title_ = value; }
        public string Tit1 { get => Tit1_; set => Tit1_ = value; }
        public string Tit2 { get => Tit2_; set => Tit2_ = value; }
        public string Tit3 { get => Tit3_; set => Tit3_ = value; }
        public string Tit4 { get => Tit4_; set => Tit4_ = value; }
        public string Tit5 { get => Tit5_; set => Tit5_ = value; }
        public string Des1 { get => Des1_; set => Des1_ = value; }
        public string Des2 { get => Des2_; set => Des2_ = value; }
        public string Des3 { get => Des3_; set => Des3_ = value; }
        public string Des4 { get => Des4_; set => Des4_ = value; }
        public string Des5 { get => Des5_; set => Des5_ = value; }
        public string Photo1 { get => Photo1_; set => Photo1_ = value; }
        public string Photo2 { get => Photo2_; set => Photo2_ = value; }
        public string Photo3 { get => Photo3_; set => Photo3_ = value; }
        public string Photo4 { get => Photo4_; set => Photo4_ = value; }
        public string Photo5 { get => Photo5_; set => Photo5_ = value; }
        public string Photo { get => Photo_; set => Photo_ = value; }
    }
}
