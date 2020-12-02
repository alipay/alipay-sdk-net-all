using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIDetailQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIDetailQueryResult : AopObject
    {
        /// <summary>
        /// 业财受理单基础模型
        /// </summary>
        [XmlArray("acceptance_list")]
        [XmlArrayItem("g_f_a_open_a_p_i_base_acceptance")]
        public List<GFAOpenAPIBaseAcceptance> AcceptanceList { get; set; }

        /// <summary>
        /// 业财受理指令
        /// </summary>
        [XmlArray("command_list")]
        [XmlArrayItem("g_f_a_open_a_p_i_command")]
        public List<GFAOpenAPICommand> CommandList { get; set; }
    }
}
