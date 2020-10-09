using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Vat_Tu.Bussiness
{
    public class CalulateInventory
    {
        public CalulateInventory() 
        { 
        
        }

        public void ProcessCalculate(Data_QLKDataContext db, decimal quantity, long productId, string batch, string serialNo, long warehouseId_From, long warehouseId_To)
        {
            try 
            {
                CalculateWareHouse(db, quantity, productId, batch, serialNo, warehouseId_From, 1);
                CalculateWareHouse(db, quantity, productId, batch, serialNo, warehouseId_To, 2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CalculateWareHouse(Data_QLKDataContext db, decimal quantity, long productId, string batch, string serialNo, long warehouseId, int type) //1: nhap, 2 xuat 
        {
            try
            {
                if (quantity != 0 && productId != 0)
                {
                    if (warehouseId != 0)
                    {
                        var tonkho = (from tk in db.TON_KHOs
                                      where tk.Vat_Tu_Id == productId
                                      && tk.Kho_Id == warehouseId
                                      && tk.Lo_Vat_Tu == batch
                                      && tk.Serial_No == serialNo
                                      && !tk.IsDeleted.Value
                                      select tk).FirstOrDefault();

                        if (tonkho != null)
                        {
                            if (type == 1)
                            {
                                tonkho.So_Luong += quantity;
                            }
                            else 
                            {
                                tonkho.So_Luong -= quantity;
                            }
                            tonkho.ModifiedDate = DateTime.Now;
                        }
                        else
                        {
                            var item = new TON_KHO();
                            item.CreatedDate = DateTime.Now;
                            item.IsDeleted = false;
                            item.Kho_Id = warehouseId;
                            item.Lo_Vat_Tu = batch;
                            item.Serial_No = serialNo;
                            if (type == 1)
                            {
                                item.So_Luong = quantity;
                            }
                            else
                            {
                                item.So_Luong = (quantity * -1);
                            }
                            item.Vat_Tu_Id = productId;

                            db.TON_KHOs.InsertOnSubmit(item);
                        }
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
