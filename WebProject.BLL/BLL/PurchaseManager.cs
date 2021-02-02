﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Repository.Repository;
using WebProject.Model.Model;

namespace WebProject.BLL.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public bool Add(Purchase purchase)
        {
            return _purchaseRepository.Add(purchase);
        }
        public bool Delete(Purchase purchase)
        {
            return _purchaseRepository.Delete(purchase);
        }
        public List<Purchase> GetAll()
        {
            return _purchaseRepository.GetAll();
        }
        public Purchase GetById(int id)
        {
            return _purchaseRepository.GetById(id);
        }
        public Purchase GetByInvoiceNo(string invoiceNo)
        {
            return _purchaseRepository.GetByInvoiceNo(invoiceNo);
        }
        public PurchaseDetails GetPurchaseDetails(int productId, int categoryId)
        {
            return _purchaseRepository.GetPurchaseDetails(productId, categoryId);
        }
        public List<PurchaseDetails> GetPurchaseQuantityDetails(int productId, int categoryId)
        {
            return _purchaseRepository.GetPurchaseQuantityDetails(productId, categoryId);
        }
        public bool IsInvoiceNoExist(string invoiceNo)
        {
            return _purchaseRepository.IsInvoiceNoExist(invoiceNo);
        }
    }
}