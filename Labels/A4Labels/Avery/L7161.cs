using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpPDFLabel.Labels.A4Labels.Avery
{
    /// <summary>
    /// Dimensions: 63.5mm x 46.6mm 
    /// Per Sheet: 18 per sheet 
    /// Inkjet code: J8161
    /// </summary>
    public class L7161 : LabelDefinition
    {
        public L7161()
        {
            _Width = 63.5;
            _Height = 46.6;
            _HorizontalGapWidth = 2.5;
            _VerticalGapHeight = 0;

            _PageMarginTop = 8.7;
            _PageMarginBottom = 8.7;
            _PageMarginLeft = 7.25;
            _PageMarginRight = 7.25;

            PageSize = Enums.PageSize.A4;
            LabelsPerRow = 3;
            LabelRowsPerPage = 6;
        }
    }
}
