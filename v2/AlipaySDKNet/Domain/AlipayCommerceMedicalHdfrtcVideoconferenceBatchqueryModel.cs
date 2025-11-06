using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 视频会议ID集合
        /// </summary>
        [XmlArray("video_conference_id_list")]
        [XmlArrayItem("number")]
        public List<long> VideoConferenceIdList { get; set; }
    }
}
