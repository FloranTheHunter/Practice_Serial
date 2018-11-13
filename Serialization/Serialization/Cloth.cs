using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    class Cloth
    {
        [DataMember]
        public string Color;

        [DataMember]
        public string Style;

        [DataMember]
        public int Size;

        [DataMember]
        public string Gender;
    }
}
