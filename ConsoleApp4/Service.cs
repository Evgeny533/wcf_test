using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp4
{
    class Service : IContract
    {
        public string xmlLoad(string fileName)
        {
            log4net.ILog log;
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            Logger.InitLogger();
                               
            try
            {
                string path = "C:/1/" + fileName;

                XmlSerializer serializer = new XmlSerializer(typeof(@return));

                StreamReader reader = new StreamReader(path);
                var xmlValues = (@return)serializer.Deserialize(reader);
                reader.Close();

                ProITEntities dbContext = new ProITEntities();


                dbContext.Configuration.AutoDetectChangesEnabled = false;

                //Запись в БД
                for (int iIndex = 0; iIndex < xmlValues.AGREEMENT.Length; iIndex++)
                {
                    var _xmlValues = xmlValues.AGREEMENT[iIndex];

                    AGREEMENT _agreement = new AGREEMENT();
                    AGREEMENT_ORG _agreement_org = new AGREEMENT_ORG();
                    BO _bo = new BO();

                    //AGREEMENT
                    _agreement.budgetId = _xmlValues.budgetId.ToString();
                    _agreement.budgetSumm = _xmlValues.budgetSumm;
                    _agreement.caption = _xmlValues.caption;
                    _agreement.dateFrom = (DateTime?)Convert.ToDateTime(_xmlValues.dateFrom);
                    _agreement.dateTo = (DateTime?)Convert.ToDateTime(_xmlValues.dateTo);
                    _agreement.KADM = _xmlValues.KADM;
                    _agreement.id = Convert.ToInt64(_xmlValues.id);

                    //есть ли в БД данные по текущему договору?
                    var isAgreement = dbContext.AGREEMENT.AsNoTracking().Any<AGREEMENT>(s => s.id == _agreement.id);
                    if (!isAgreement) dbContext.AGREEMENT.Add(_agreement);

                    //AGREEMENT_ORG
                    _agreement_org.agreementSumm = _xmlValues.AGREEMENT_ORG.agreementSumm;
                    _agreement_org.budgetReqsSumm = _xmlValues.AGREEMENT_ORG.budgetReqsSumm;
                    _agreement_org.caption = _xmlValues.AGREEMENT_ORG.caption;
                    _agreement_org.id = Convert.ToInt64(_xmlValues.AGREEMENT_ORG.id);
                    _agreement_org.subsidySumm = _xmlValues.AGREEMENT_ORG.subsidySumm;
                    _agreement_org.id_agreement = _agreement.id;

                    //есть ли в БД данные по текущему договору_орг?
                    var isAgreementORG = dbContext.AGREEMENT_ORG.AsNoTracking().Any<AGREEMENT_ORG>(s => s.id == _agreement_org.id);
                    if (!isAgreementORG) dbContext.AGREEMENT_ORG.Add(_agreement_org);

                    //SCHEDULE
                    for (int jIndex = 0; jIndex < _xmlValues.AGREEMENT_ORG.SCHEDULE.Length; jIndex++)
                    {
                        SCHEDULE _schedule = new SCHEDULE();
                        _schedule.transferDate = (DateTime?)Convert.ToDateTime(_xmlValues.AGREEMENT_ORG.SCHEDULE[jIndex].transferDate);
                        _schedule.transferSumm = _xmlValues.AGREEMENT_ORG.SCHEDULE[jIndex].transferSumm.ToString();
                        _schedule.id_agreement_org = _agreement_org.id;
                        dbContext.SCHEDULE.Add(_schedule);
                    }
                    //BO
                    if (_xmlValues.AGREEMENT_ORG.BO != null)
                    {
                        _bo.grbs = _xmlValues.AGREEMENT_ORG.BO.grbs;
                        _bo.kcsr = _xmlValues.AGREEMENT_ORG.BO.kcsr;
                        _bo.kesr = _xmlValues.AGREEMENT_ORG.BO.kesr;
                        _bo.kfsr = _xmlValues.AGREEMENT_ORG.BO.kfsr;
                        _bo.kvr = _xmlValues.AGREEMENT_ORG.BO.kvr;
                        _bo.period = _xmlValues.AGREEMENT_ORG.BO.period;
                        _bo.id_agreement_org = _agreement_org.id;
                        _bo.amount = _xmlValues.AGREEMENT_ORG.BO.amount;
                        _bo.Bo_number = _xmlValues.AGREEMENT_ORG.BO.Bo_number;
                        dbContext.BO.Add(_bo);
                    }

                    dbContext.SaveChanges();
                }

                
                //запись лога в файл
                Logger.Log.Info("Данные из файла " + fileName + " успешно загружены");
                //запись лога в бд
                log.Info("Данные из файла " + fileName + " успешно загружены");
                return "Данные из файла " + fileName + " успешно загружены";
            }
            catch(Exception ex)
            {
                //запись лога в файл
                Logger.Log.Error("Данные из файла " + fileName + " не загружены");
                //запись лога в бд
                log.Error(ex);
                return "Ошибка в xmlLoad - " + ex.ToString();
            }

            
        }
    }
}
