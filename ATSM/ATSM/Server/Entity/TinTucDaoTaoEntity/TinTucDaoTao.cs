using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace JVL
{
    public class TinTucDaoTao
    {
        //
        int id;
        //
        int? matlt;
        //
        String macbgv;
        //
        String tieude;
        //
        String tomtat;
        //
        String noidung;
        //
        String filedinhkem;
        //
        DateTime? thoigian;
        //
        String hinhanh;
        //
        DateTime? deleteDate;
        //
        int? deleteUserId;
        
        public TinTucDaoTao()
        {
        
        }
        
        public virtual int Id { get { return id; } set { id = value; } }
        
        public virtual int? Matlt { get { return matlt; } set { matlt = value; } }
        
        public virtual String Macbgv { get { return macbgv; } set { macbgv = value; } }
        
        public virtual String Tieude { get { return tieude; } set { tieude = value; } }
        
        public virtual String Tomtat { get { return tomtat; } set { tomtat = value; } }
        
        public virtual String Noidung { get { return noidung; } set { noidung = value; } }
        
        public virtual String Filedinhkem { get { return filedinhkem; } set { filedinhkem = value; } }
        
        public virtual DateTime? Thoigian { get { return thoigian; } set { thoigian = value; } }
        
        public virtual String Hinhanh { get { return hinhanh; } set { hinhanh = value; } }
        
        public virtual DateTime? DeleteDate { get { return deleteDate; } set { deleteDate = value; } }
        
        public virtual int? DeleteUserId { get { return deleteUserId; } set { deleteUserId = value; } }
        
    }
}
