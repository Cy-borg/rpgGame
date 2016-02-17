//species generator by cy on 17.2.16
//species require anatomical traits, biological traits and mental traits
class speciesGen
{
  class headCount
  {
    Random rand = new Random();
    int headChance = rand.Next(1,100001);

    if (headChance <= 1)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 10
    }

    else if (headChance >=2, <= 4)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 9
    }

    else if  (headChance >=5, <=8)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 8
    }

    else if (headChance >=9, <=13)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 7
    }

    else if (headChance >=14, <=19)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 6
    }

    else if (headChance >=20, <=26)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 5
    }

    else if (headChance >=27, <=34)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 4
    }

    else if (headChance >=35, <=43)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 3
    }

    else if (headChance >=44, <=100)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 2
    }

    else (headchance >=101)
    {
      rogueLikeSystems.actorQualities.actorBody.head = 1
    }
  }
  class armCount
  {
    Random rand = new Random();
    int armChance = rand.Next(1,100001);

    if (armChance <= 1)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 9
    }

    else if (armChance >=2, <= 4)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 7
    }

    else if (armChance >=5, <=8)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 5
    }

    else if (armChance >=9, <=13)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 3
    }

    else if (armChance >=14, <=19)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 1
    }

    else if (armChance >=20, <=26)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 8
    }

    else if (armChance >=27, <=34)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 6
    }

    else if (armChance >=35, <=43)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 4
    }

    else if (armChance >=44, <=100)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 3
    }

    else (armChance >=101)
    {
      rogueLikeSystems.actorQualities.actorBody.arm = 2
    }
  }
  class eyecount
  {
    Random rand = new Random();
    int eyeChance = rand.Next(1,100001);

    if (eyeChance <= 1)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 10
    }

    else if (eyeChance >=2, <= 4)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 9
    }

    else if (eyeChance >=5, <=8)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 8
    }

    else if (eyeChance >=9, <=13)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 7
    }

    else if (eyeChance >=14, <=19)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 6
    }

    else if (eyeChance >=20, <=26)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 5
    }

    else if (eyeChance >=27, <=34)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 1
    }

    else if (eyeChance >=35, <=43)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 4
    }

    else if (eyeChance >=44, <=100)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 3
    }

    else (eyeChance >=101)
    {
      rogueLikeSystems.actorQualities.actorBody.eye = 2
    }
  }
}
