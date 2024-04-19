using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsLessonUserlessonrecordSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsLessonUserlessonrecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 运动币数量
        /// </summary>
        [XmlElement("sport_coin_num")]
        public long SportCoinNum { get; set; }
    }
}
