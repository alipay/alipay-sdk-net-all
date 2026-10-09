using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockPatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockPatchQueryModel : AopObject
    {
        /// <summary>
        /// test2222
        /// </summary>
        [XmlElement("b_query")]
        public string BQuery { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("c_body")]
        public string CBody { get; set; }

        /// <summary>
        /// tst
        /// </summary>
        [XmlElement("complex_a")]
        public TestDemo ComplexA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("complex_b")]
        public TestDemo ComplexB { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_c")]
        public TestDemoWzw ComplexC { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_d")]
        public TestDemoWzw ComplexD { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("id_type_modify_open_id")]
        public string IdTypeModifyOpenId { get; set; }

        /// <summary>
        /// id_type
        /// </summary>
        [XmlElement("id_typea")]
        public string IdTypea { get; set; }

        /// <summary>
        /// 元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uida")]
        public string Uida { get; set; }
    }
}
