﻿using Microsoft.EntityFrameworkCore;

using Moskit.Models.Entity.AccountingSpace;
using Moskit.Models.Entity.BankingSpace;
using Moskit.Models.Entity.CompanySpace;
using Moskit.Models.Entity.CustomerSpace;
using Moskit.Models.Entity.DocumentSpace;
using Moskit.Models.Entity.GeneralSpace;
using Moskit.Models.Entity.IdentitySpace;
using Moskit.Models.Entity.InventorySpace;
using Moskit.Models.Entity.PurchasesSpace;
using Moskit.Models.Entity.SalesSpace;
using Moskit.Models.Entity.SupplierSpace;
using Moskit.Models.Entity.SystemSpace;

namespace Moskit.Models.Entity
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
            MailSettings.BuildModel(builder);
            RegionalSettings.BuildModel(builder);
            Country.BuildModel(builder);
            Currency.BuildModel(builder);
            DateFormat.BuildModel(builder);
            ValueAddedTax.BuildModel(builder);
            ShippingMethod.BuildModel(builder);
            ShippingTerm.BuildModel(builder);
            PaymentMethod.BuildModel(builder);
            SystemCompanySetup.BuildModel(builder);

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

            /************************************************************************************************
             * Supplier Space
             ************************************************************************************************/
            Supplier.BuildModel(builder);
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
