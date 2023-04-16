using Open_Closed;

var magic = new MagicClass();

List<MagicClass> magicList = new List<MagicClass>
{
    new FireMagic(),
    new WaterMagic()
};

magic.ChooseMagic(magicList, 150);