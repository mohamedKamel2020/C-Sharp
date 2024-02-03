using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystemAPI
{
    public class DMSDocument : Document
    {
        private const string docType = "DMS Document";
        public DMSDocument(int id) : base(id)
        {

        }
        public override string GetSerializedDocumentMetadata(DocumentMetaDataFormat documentMetaDataFormat)
        {
            return base.GetSerializedDocumentMetadata(documentMetaDataFormat) + "," + docType;
        }
        public override bool IsDocIdValid(int id)
        {
            if (id >= 0 && id <= 1000)
            {
                return true;
            }
            return false;
        }
    }
}
