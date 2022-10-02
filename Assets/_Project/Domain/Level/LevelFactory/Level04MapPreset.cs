namespace LudumDare51.Domain
{
    public static class Level04MapPreset
    {
        private static FloorId[][] floorIds = new FloorId[MapSize.Size][]
        {
            new FloorId[MapSize.Size] { FloorId.Ceiling, FloorId.Ceiling, FloorId.Ceiling, FloorId.CeilingTop, FloorId.CeilingTop, FloorId.CeilingTop, FloorId.CeilingTop, FloorId.CeilingTop, FloorId.Ceiling, FloorId.Ceiling },
            new FloorId[MapSize.Size] { FloorId.Ceiling, FloorId.CeilingTop, FloorId.Cornertopleft, FloorId.Wall, FloorId.Wall, FloorId.Door, FloorId.Wall, FloorId.Wall, FloorId.Cornertopright, FloorId.Ceiling },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Wall, FloorId.Wall, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Ceilingright },
            new FloorId[MapSize.Size] { FloorId.Ceilingleft, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Bath2, FloorId.Bath, FloorId.Ceilingright },
        };
        
        private static CosmeticId[][] cosmeticIds = new CosmeticId[MapSize.Size][]
        {
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
            new CosmeticId[MapSize.Size] { CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None,CosmeticId.None},
        };
        
                
        private static InteractionId[][] interactionIds = new InteractionId[MapSize.Size][]
        {
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
            new InteractionId[MapSize.Size] { default,default,default,default,default,default,default,default,default,default},
        };

        public static Level GetLevel()
        {
            var floorLayer = new FloorLayer(floorIds);
            var cosmeticLayer = new CosmeticLayer(cosmeticIds);
            var interactionLayer = new InteractionLayer(interactionIds);
            var map = new Map(floorLayer, cosmeticLayer, interactionLayer);
            return new Level(LevelId.Level4, map);
        }
    }
}