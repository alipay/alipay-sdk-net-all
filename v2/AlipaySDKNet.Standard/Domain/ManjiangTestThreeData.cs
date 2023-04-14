using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestThreeData Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestThreeData : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("test_complex")]
        public ManjiangTestLevelTwoData TestComplex { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("test_level_three")]
        public string TestLevelThree { get; set; }
    }
}
