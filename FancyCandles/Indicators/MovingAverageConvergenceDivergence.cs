using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FancyCandles.Indicators
{
    public sealed class MovingAverageConvergenceDivergence : OverlayIndicator
    {
        //---------------------------------------------------------------------------------------------------------------------------------------
        ///<summary>Gets the static name of this OverlayIndicator.</summary>
        ///<value>The static name of this OverlayIndicator.</value>
        public static string StaticName { get { return "Moving Average Convergence Divergence"; } }

        ///<summary>Gets the short name of this OverlayIndicator object. Implements the <see cref="OverlayIndicator.ShortName"/> abstract property inherited from the <see cref="OverlayIndicator"/> base class.</summary>
        ///<value>The short name of this OverlayIndicator object.</value>
        ///<remarks>
        ///The short name of an OverlayIndicator object usually contains no instance parameter values.
        ///</remarks>
        public override string ShortName { get { return "MACD"; } }

        public override string FullName => throw new NotImplementedException();

        public override string PropertiesEditorXAML => throw new NotImplementedException();

        public override double GetIndicatorValue(int candle_i)
        {
            throw new NotImplementedException();
        }

        public override void OnRender(DrawingContext drawingContext, IntRange visibleCandlesRange, CandleExtremums visibleCandlesExtremums, double candleWidth, double gapBetweenCandles, double RenderHeight)
        {
            throw new NotImplementedException();
        }

        protected override void OnLastCandleChanged()
        {
            throw new NotImplementedException();
        }

        protected override void OnNewCandleAdded()
        {
            throw new NotImplementedException();
        }

        protected override void ReCalcAllIndicatorValues()
        {
            throw new NotImplementedException();
        }
    }
}
