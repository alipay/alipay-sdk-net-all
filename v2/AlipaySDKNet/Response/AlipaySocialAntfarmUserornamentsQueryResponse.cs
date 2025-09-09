using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntfarmUserornamentsQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmUserornamentsQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前用户小鸡装扮信息
        /// </summary>
        [XmlArray("user_ornament_list")]
        [XmlArrayItem("antfarm_user_ornament")]
        public List<AntfarmUserOrnament> UserOrnamentList { get; set; }
    }
}
