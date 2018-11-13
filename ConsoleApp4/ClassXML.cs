using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    

        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class @return
        {

            private returnAGREEMENT[] aGREEMENTField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AGREEMENT")]
            public returnAGREEMENT[] AGREEMENT
            {
                get
                {
                    return this.aGREEMENTField;
                }
                set
                {
                    this.aGREEMENTField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class returnAGREEMENT
        {

            private returnAGREEMENTAGREEMENT_ORG aGREEMENT_ORGField;

            private string kADMField;

            private ulong budgetIdField;

            private string budgetSummField;

            private string captionField;

            private string dateFromField;

            private string dateToField;

            private ulong idField;

            /// <remarks/>
            public returnAGREEMENTAGREEMENT_ORG AGREEMENT_ORG
            {
                get
                {
                    return this.aGREEMENT_ORGField;
                }
                set
                {
                    this.aGREEMENT_ORGField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string KADM
            {
                get
                {
                    return this.kADMField;
                }
                set
                {
                    this.kADMField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong budgetId
            {
                get
                {
                    return this.budgetIdField;
                }
                set
                {
                    this.budgetIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string budgetSumm
            {
                get
                {
                    return this.budgetSummField;
                }
                set
                {
                    this.budgetSummField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string caption
            {
                get
                {
                    return this.captionField;
                }
                set
                {
                    this.captionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string dateFrom
            {
                get
                {
                    return this.dateFromField;
                }
                set
                {
                    this.dateFromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string dateTo
            {
                get
                {
                    return this.dateToField;
                }
                set
                {
                    this.dateToField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class returnAGREEMENTAGREEMENT_ORG
        {

            private returnAGREEMENTAGREEMENT_ORGSCHEDULE[] sCHEDULEField;

            private returnAGREEMENTAGREEMENT_ORGBO boField;

            private string agreementSummField;

            private string budgetReqsSummField;

            private string captionField;

            private ulong idField;

            private string subsidySummField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SCHEDULE")]
            public returnAGREEMENTAGREEMENT_ORGSCHEDULE[] SCHEDULE
            {
                get
                {
                    return this.sCHEDULEField;
                }
                set
                {
                    this.sCHEDULEField = value;
                }
            }

            /// <remarks/>
            public returnAGREEMENTAGREEMENT_ORGBO BO
            {
                get
                {
                    return this.boField;
                }
                set
                {
                    this.boField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string agreementSumm
            {
                get
                {
                    return this.agreementSummField;
                }
                set
                {
                    this.agreementSummField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string budgetReqsSumm
            {
                get
                {
                    return this.budgetReqsSummField;
                }
                set
                {
                    this.budgetReqsSummField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string caption
            {
                get
                {
                    return this.captionField;
                }
                set
                {
                    this.captionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string subsidySumm
            {
                get
                {
                    return this.subsidySummField;
                }
                set
                {
                    this.subsidySummField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class returnAGREEMENTAGREEMENT_ORGSCHEDULE
        {

            private string transferDateField;

            private decimal transferSummField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string transferDate
            {
                get
                {
                    return this.transferDateField;
                }
                set
                {
                    this.transferDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal transferSumm
            {
                get
                {
                    return this.transferSummField;
                }
                set
                {
                    this.transferSummField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class returnAGREEMENTAGREEMENT_ORGBO
        {

            private  string  bo_numberField;

            private string amountField;

            private string grbsField;

            private string kcsrField;

            private string kesrField;

            private string kfsrField;

            private string kvrField;

            private string periodField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Bo_number
            {
                get
                {
                    return this.bo_numberField;
                }
                set
                {
                    this.bo_numberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string grbs
            {
                get
                {
                    return this.grbsField;
                }
                set
                {
                    this.grbsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string kcsr
            {
                get
                {
                    return this.kcsrField;
                }
                set
                {
                    this.kcsrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string kesr
            {
                get
                {
                    return this.kesrField;
                }
                set
                {
                    this.kesrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string kfsr
            {
                get
                {
                    return this.kfsrField;
                }
                set
                {
                    this.kfsrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string kvr
            {
                get
                {
                    return this.kvrField;
                }
                set
                {
                    this.kvrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string period
            {
                get
                {
                    return this.periodField;
                }
                set
                {
                    this.periodField = value;
                }
            }



        
    }

}
