﻿using Microsoft.EntityFrameworkCore;

using OskitAPI.Models.Entity.AccountingSpace;
using OskitAPI.Models.Entity.BankingSpace;
using OskitAPI.Models.Entity.CompanySpace;
using OskitAPI.Models.Entity.CustomerSpace;
using OskitAPI.Models.Entity.DocumentSpace;
using OskitAPI.Models.Entity.GeneralSpace;
using OskitAPI.Models.Entity.IdentitySpace;
using OskitAPI.Models.Entity.InventorySpace;
using OskitAPI.Models.Entity.PurchasesSpace;
using OskitAPI.Models.Entity.SalesSpace;
using OskitAPI.Models.Entity.SupplierSpace;
using OskitAPI.Models.Entity.SystemSpace;

namespace OskitAPI.Models.Entity
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
            CompanyDefaultValueAddedTax.BuildModel(builder);
            CompanyValueAddedTax.BuildModel(builder);
            CompanyUser.BuildModel(builder);

            /************************************************************************************************
             * System Space
             ************************************************************************************************/
            CompanyMailSettings.BuildModel(builder);
            CompanyRegionalSettings.BuildModel(builder);
            Country.BuildModel(builder);
            Currency.BuildModel(builder);
            DateFormat.BuildModel(builder);
            ValueAddedTax.BuildModel(builder);
            ShippingMethod.BuildModel(builder);
            ShippingTerm.BuildModel(builder);
            PaymentMethod.BuildModel(builder);
            SystemCompanyNumber.BuildModel(builder);

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