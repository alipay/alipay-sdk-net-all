using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataSyncResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 校验信息列表
        /// </summary>
        [XmlArray("check_info_list")]
        [XmlArrayItem("mpcpormo_data_check_info")]
        public List<MpcpormoDataCheckInfo> CheckInfoList { get; set; }
    }
}
