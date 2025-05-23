using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInstitutionExportQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInstitutionExportQueryResponse : AopResponse
    {
        /// <summary>
        /// 安诊儿驾驶舱每日明细导出数据字段对应的中文 [   {     "name": "机构名称",     "value": "orgName"   },   {     "name": "交互DAU",     "value": "interUv"   },   {     "name": "服务曝光DAU",     "value": "servExpoUv"   },   {     "name": "服务点击DAU",     "value": "servClkUv"   },   {     "name": "问答DAU",     "value": "chatUv"   },   {     "name": "服务曝光点击率",     "value": "servUvCtr"   } ]
        /// </summary>
        [XmlElement("daily_export_data")]
        public string DailyExportData { get; set; }
    }
}
