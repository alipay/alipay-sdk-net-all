using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarRentcarSpuexpoQueryResponse.
    /// </summary>
    public class AlipayEcoMycarRentcarSpuexpoQueryResponse : AopResponse
    {
        /// <summary>
        /// 曝光信息
        /// </summary>
        [XmlArray("expo_infos")]
        [XmlArrayItem("rent_car_spu_expo_info")]
        public List<RentCarSpuExpoInfo> ExpoInfos { get; set; }

        /// <summary>
        /// 曝光信息总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
