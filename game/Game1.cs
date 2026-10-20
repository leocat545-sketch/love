using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
namespace Demo {
  public class Game1 : Game {
    GraphicsDeviceManager g; SpriteBatch sb; Texture2D px; Vector2 p = new Vector2(300, 300);
    public Game1() { g = new GraphicsDeviceManager(this); g.IsFullScreen = true; g.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight; }
    protected override void LoadContent() { sb = new SpriteBatch(GraphicsDevice); px = new Texture2D(GraphicsDevice, 1, 1); px.SetData(new[] { Color.White }); }
    protected override void Update(GameTime t) { var ts = TouchPanel.GetState(); if (ts.Count > 0) p = ts[0].Position; base.Update(t); }
    protected override void Draw(GameTime t) { GraphicsDevice.Clear(Color.CornflowerBlue); sb.Begin(); sb.Draw(px, new Rectangle((int)p.X - 40, (int)p.Y - 40, 80, 80), Color.Yellow); sb.End(); base.Draw(t); }
  }
}
