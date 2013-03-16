package {
	import flash.display.Bitmap;
	import flash.display.BitmapData;
	import flash.display.Sprite;
	
	public class WaterMark extends Sprite {
		
		[Embed(source='logo.png')]
		public var mark:Class;
		
		public function getWaterMark(): BitmapData {
			var pic:Bitmap = new mark();
			return pic.bitmapData;
		}

	}
}