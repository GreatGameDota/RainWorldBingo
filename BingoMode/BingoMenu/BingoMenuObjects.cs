using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;
using UnityEngine;

namespace BingoMode.BingoMenu
{
    public static class BingoMenuObjects
    {
        // I just want colors dawg
        public class BingoSymbolButton : SymbolButton
        {
            public Color? spriteColor;
            public Color? roundedRectColor;
            public BingoSymbolButton(Menu.Menu menu, MenuObject owner, string symbolName, string singalText, Vector2 pos, Color? spriteColor = null, Color? roundedRectColor = null) : base(menu, owner, symbolName, singalText, pos)
            {
                this.spriteColor = spriteColor;
                this.roundedRectColor = roundedRectColor;
            }

            public override void GrafUpdate(float timeStacker)
            {
                base.GrafUpdate(timeStacker);
                if (spriteColor.HasValue)
                {
                    this.symbolSprite.color = spriteColor.Value;
                }
                if (roundedRectColor.HasValue)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        this.roundedRect.sprites[this.roundedRect.SideSprite(i)].color = roundedRectColor.Value;
                        this.roundedRect.sprites[this.roundedRect.CornerSprite(i)].color = roundedRectColor.Value;
                    }
                }
            }
        }
    }
}
