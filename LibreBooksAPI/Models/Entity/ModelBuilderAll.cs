﻿using LibreBooks.Models.Entity.AccountingSpace;
using LibreBooks.Models.Entity.BankingSpace;
using LibreBooks.Models.Entity.CompanySpace;
using LibreBooks.Models.Entity.CustomerSpace;
using LibreBooks.Models.Entity.DocumentSpace;
using LibreBooks.Models.Entity.GeneralSpace;
using LibreBooks.Models.Entity.IdentitySpace;
using LibreBooks.Models.Entity.InventorySpace;
using LibreBooks.Models.Entity.PurchasesSpace;
using LibreBooks.Models.Entity.SalesSpace;
using LibreBooks.Models.Entity.SupplierSpace;
using LibreBooks.Models.Entity.SystemSpace;

using LibreBooksAPI.Models.Entity.CompanySpace;
using LibreBooksAPI.Models.Entity.CustomerSpace;
using LibreBooksAPI.Models.Entity.InventorySpace;
using LibreBooksAPI.Models.Entity.SupplierSpace;

using Microsoft.EntityFrameworkCore;

namespace LibreBooks.Models.Entity
{
    public class ModelsBuilderAll
    {
        public static void BuildModels (ModelBuilder builder)
        {
            /************************************************************************************************
             * Uer Space
             ************************************************************************************************/
            User.BuildModel(builder);
            Role.BuildModel(builder);
            RoleClaim.BuildModel(builder);
            UserRole.BuildModel(builder);
            UserToken.BuildModel(builder);
            UserLogin.BuildModel(builder);
            UserClaim.BuildModel(builder);

            /************************************************************************************************
             * Inventory Space
             ************************************************************************************************/
            Item.BuildModel(builder);
            ItemCategory.BuildModel(builder);
            ItemInventory.BuildModel(builder);
            ItemAdjustment.BuildModel(builder);
            ItemSetup.BuildModel(builder);

            /************************************************************************************************
             * Document Space
             ************************************************************************************************/
            DocumentStatus.BuildModel(builder);
            DocumentSetup.BuildModel(builder);
            DocumentPrintTemplate.BuildModel(builder);

            /************************************************************************************************
             * Sales Space
             ************************************************************************************************/
            SalesDocument.BuildModel(builder);
            SalesCredit.BuildModel(builder);
            SalesDocumentLine.BuildModel(builder);
            SalesInvoice.BuildModel(builder);
            SalesReceipt.BuildModel(builder);
            SalesOrder.BuildModel(builder);
            SalesOrderInvoice.BuildModel(builder);
            SalesQuote.BuildModel(builder);
            SalesQuoteOrder.BuildModel(builder);
            SalesInvoiceReceipt.BuildModel(builder);
            SalesLine.BuildModel(builder);
            SalesDocumentCustomerDetails.BuildModel(builder);
            SalesPerson.BuildModel(builder);
            SalesInvoiceCredit.BuildModel(builder);
            SalesDocumentNote.BuildModel(builder);

            /************************************************************************************************
             * Company Space
             ************************************************************************************************/
            Company.BuildModel(builder);
            CompanyDefaultBankAccount.BuildModel(builder);
            CompanyDefaultTaxType.BuildModel(builder);
            CompanyTaxType.BuildModel(builder);
            CompanyUser.BuildModel(builder);
            CompanyMailSettings.BuildModel(builder);
            CompanyRegionalSettings.BuildModel(builder);
            CompanyLogo.BuildModel(builder);
            CompanyImage.BuildModel(builder);

            /************************************************************************************************
             * System Space
             ************************************************************************************************/
            Country.BuildModel(builder);
            Currency.BuildModel(builder);
            DateFormat.BuildModel(builder);
            TaxType.BuildModel(builder);
            ShippingMethod.BuildModel(builder);
            ShippingTerm.BuildModel(builder);
            PaymentMethod.BuildModel(builder);
            CompanySetup.BuildModel(builder);
            BusinessSector.BuildModel(builder);

            /************************************************************************************************
             * Customer Space
             ************************************************************************************************/
            Customer.BuildModel(builder);
            CustomerCategory.BuildModel(builder);
            CustomerNote.BuildModel(builder);
            CustomerContact.BuildModel(builder);
            CustomerAccountsContact.BuildModel(builder);
            CustomerWriteOff.BuildModel(builder);
            CustomerAdjustment.BuildModel(builder);
            CustomerSetup.BuildModel(builder);

            /************************************************************************************************
             * Accounting Space
             ************************************************************************************************/
            Account.BuildModel(builder);
            AccountCategory.BuildModel(builder);
            AccountCashFlowType.BuildModel(builder);
            Journal.BuildModel(builder);
            JournalNote.BuildModel(builder);

            /************************************************************************************************
             * Supplier Space
             ************************************************************************************************/
            Supplier.BuildModel(builder);
            SupplierNote.BuildModel(builder);
            SupplierAdjustment.BuildModel(builder);
            SupplierContact.BuildModel(builder);
            SupplierAccountsContact.BuildModel(builder);
            SupplierCategory.BuildModel(builder);
            SupplierSetup.BuildModel(builder);

            /************************************************************************************************
             * Purchasing Space
             ************************************************************************************************/
            PurchaseDocument.BuildModel(builder);
            PurchaseDocumentLine.BuildModel(builder);
            PurchaseInvoice.BuildModel(builder);
            PurchaseOrder.BuildModel(builder);
            PurchaseOrderInvoice.BuildModel(builder);
            PurchaseReceipt.BuildModel(builder);
            PurchaseInvoiceReceipt.BuildModel(builder);
            PurchaseReturn.BuildModel(builder);
            PurchaseLine.BuildModel(builder);
            PurchaseBuyer.BuildModel(builder);
            PurchaseInvoiceReturn.BuildModel(builder);
            PurchaseDocumentNote.BuildModel(builder);
            PurchaseDocumentSupplierDetails.BuildModel(builder);

            /************************************************************************************************
             * Banking Space
             ************************************************************************************************/
            BankAccount.BuildModel(builder);
            BankAccountCategory.BuildModel(builder);

            /************************************************************************************************
             * General Space
             ************************************************************************************************/
            Contact.BuildModel(builder);
            Note.BuildModel(builder);
        }
    }
}
