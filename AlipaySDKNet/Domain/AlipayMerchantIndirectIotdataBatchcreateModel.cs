using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotdataBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotdataBatchcreateModel : AopObject
    {
        /// <summary>
        /// 播报记录详情字段按照要求传入，列表长度不超过20
        /// </summary>
        [XmlArray("speech_record_list")]
        [XmlArrayItem("speech_record_detail")]
        public List<SpeechRecordDetail> SpeechRecordList { get; set; }
    }
}
