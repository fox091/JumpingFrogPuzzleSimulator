# JumpingFrogPuzzleSimulator
Simulates the jumping frog puzzle (https://www.youtube.com/watch?v=ZLTyX4zL2Fc) in parallel for a range of numbers of lily pads.

Spins up the work for each "number of possible jumps" in a new task and waits for all of them to finish.  Each individual simulation just uses the simle Jump() method.

Just change the numSimulations and maxPossilbeJumps at the top to simulate it.  MaxPossibleJumps includes the other bank of the river, so 50 would be 49 lily pads.

Example output from 1,000,000,000 simulations each from 2 possible jumps(1 lily pad) to 100 possible jumps(99 lily pads):

```
Number of possible jumps: 2 Average number of jumps: 1.500014146
Number of possible jumps: 3 Average number of jumps: 1.833320905
Number of possible jumps: 4 Average number of jumps: 2.083319119
Number of possible jumps: 5 Average number of jumps: 2.283370714
Number of possible jumps: 6 Average number of jumps: 2.449956126
Number of possible jumps: 7 Average number of jumps: 2.592848068
Number of possible jumps: 8 Average number of jumps: 2.71783602
Number of possible jumps: 9 Average number of jumps: 2.828967342
Number of possible jumps: 10 Average number of jumps: 2.929005387
Number of possible jumps: 11 Average number of jumps: 3.019939058
Number of possible jumps: 12 Average number of jumps: 3.103125901
Number of possible jumps: 13 Average number of jumps: 3.180110849
Number of possible jumps: 14 Average number of jumps: 3.251585484
Number of possible jumps: 15 Average number of jumps: 3.318300908
Number of possible jumps: 16 Average number of jumps: 3.380707312
Number of possible jumps: 17 Average number of jumps: 3.439500987
Number of possible jumps: 18 Average number of jumps: 3.495065629
Number of possible jumps: 19 Average number of jumps: 3.547773042
Number of possible jumps: 20 Average number of jumps: 3.597734101
Number of possible jumps: 21 Average number of jumps: 3.645397505
Number of possible jumps: 22 Average number of jumps: 3.690821687
Number of possible jumps: 23 Average number of jumps: 3.73441245
Number of possible jumps: 24 Average number of jumps: 3.775959066
Number of possible jumps: 25 Average number of jumps: 3.815975153
Number of possible jumps: 26 Average number of jumps: 3.854458256
Number of possible jumps: 27 Average number of jumps: 3.891433024
Number of possible jumps: 28 Average number of jumps: 3.927168471
Number of possible jumps: 29 Average number of jumps: 3.961673153
Number of possible jumps: 30 Average number of jumps: 3.994965339
Number of possible jumps: 31 Average number of jumps: 4.027273597
Number of possible jumps: 32 Average number of jumps: 4.058515379
Number of possible jumps: 33 Average number of jumps: 4.088786654
Number of possible jumps: 34 Average number of jumps: 4.118147433
Number of possible jumps: 35 Average number of jumps: 4.146751639
Number of possible jumps: 36 Average number of jumps: 4.174539486
Number of possible jumps: 37 Average number of jumps: 4.201571052
Number of possible jumps: 38 Average number of jumps: 4.227954167
Number of possible jumps: 39 Average number of jumps: 4.253490367
Number of possible jumps: 40 Average number of jumps: 4.278490459
Number of possible jumps: 41 Average number of jumps: 4.302927606
Number of possible jumps: 42 Average number of jumps: 4.326740247
Number of possible jumps: 43 Average number of jumps: 4.349994453
Number of possible jumps: 44 Average number of jumps: 4.37267518
Number of possible jumps: 45 Average number of jumps: 4.394897296
Number of possible jumps: 46 Average number of jumps: 4.416795599
Number of possible jumps: 47 Average number of jumps: 4.437932585
Number of possible jumps: 48 Average number of jumps: 4.45885047
Number of possible jumps: 49 Average number of jumps: 4.479251716
Number of possible jumps: 50 Average number of jumps: 4.499225688
Number of possible jumps: 51 Average number of jumps: 4.518914634
Number of possible jumps: 52 Average number of jumps: 4.537969556
Number of possible jumps: 53 Average number of jumps: 4.556953683
Number of possible jumps: 54 Average number of jumps: 4.575352618
Number of possible jumps: 55 Average number of jumps: 4.593761463
Number of possible jumps: 56 Average number of jumps: 4.611439148
Number of possible jumps: 57 Average number of jumps: 4.629059064
Number of possible jumps: 58 Average number of jumps: 4.646190171
Number of possible jumps: 59 Average number of jumps: 4.663318249
Number of possible jumps: 60 Average number of jumps: 4.679879957
Number of possible jumps: 61 Average number of jumps: 4.696233101
Number of possible jumps: 62 Average number of jumps: 4.712491213
Number of possible jumps: 63 Average number of jumps: 4.728307035
Number of possible jumps: 64 Average number of jumps: 4.743923427
Number of possible jumps: 65 Average number of jumps: 4.759316453
Number of possible jumps: 66 Average number of jumps: 4.774500756
Number of possible jumps: 67 Average number of jumps: 4.789288031
Number of possible jumps: 68 Average number of jumps: 4.804076658
Number of possible jumps: 69 Average number of jumps: 4.818526337
Number of possible jumps: 70 Average number of jumps: 4.832721943
Number of possible jumps: 71 Average number of jumps: 4.846922557
Number of possible jumps: 72 Average number of jumps: 4.860790465
Number of possible jumps: 73 Average number of jumps: 4.874463601
Number of possible jumps: 74 Average number of jumps: 4.887958069
Number of possible jumps: 75 Average number of jumps: 4.901380648
Number of possible jumps: 76 Average number of jumps: 4.914458298
Number of possible jumps: 77 Average number of jumps: 4.927647847
Number of possible jumps: 78 Average number of jumps: 4.940249279
Number of possible jumps: 79 Average number of jumps: 4.953016546
Number of possible jumps: 80 Average number of jumps: 4.965434867
Number of possible jumps: 81 Average number of jumps: 4.977957537
Number of possible jumps: 82 Average number of jumps: 4.989965077
Number of possible jumps: 83 Average number of jumps: 5.0020252
Number of possible jumps: 84 Average number of jumps: 5.014083319
Number of possible jumps: 85 Average number of jumps: 5.025629418
Number of possible jumps: 86 Average number of jumps: 5.03730065
Number of possible jumps: 87 Average number of jumps: 5.048910343
Number of possible jumps: 88 Average number of jumps: 5.060271446
Number of possible jumps: 89 Average number of jumps: 5.071405449
Number of possible jumps: 90 Average number of jumps: 5.082572133
Number of possible jumps: 91 Average number of jumps: 5.093647573
Number of possible jumps: 92 Average number of jumps: 5.104392236
Number of possible jumps: 93 Average number of jumps: 5.115191347
Number of possible jumps: 94 Average number of jumps: 5.125816166
Number of possible jumps: 95 Average number of jumps: 5.136324391
Number of possible jumps: 96 Average number of jumps: 5.14674256
Number of possible jumps: 97 Average number of jumps: 5.15717147
Number of possible jumps: 98 Average number of jumps: 5.167256166
Number of possible jumps: 99 Average number of jumps: 5.177407255
Number of possible jumps: 100 Average number of jumps: 5.187416911
```

That simulation took around 10-15 minutes to run on my desktop computer (Ryzen 7 1700X).
