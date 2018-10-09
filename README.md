# extra_bounds

## What

* Unity boundary calculation extension 

## Requirement

* Nothing without unity

## Install

```shell
yarn add "umm@extra_bounds#^1.0.0"
```

## Usage

Calculate overlapped area

```csharp
// Collider2D collider1;
// Collider2D collider2;

float overlappedArea = collider1.CalcOverlapArea(collider2);
```

```csharp
// RectTransform rectTransform1;
// RectTransform rectTransform2;

float overlappedArea = rectTransform1.CalcOverlapArea(rectTransform2);
```

## License

Copyright (c) 2018 Takuma Maruyama

Released under the  license, see [LICENSE.txt](LICENSE.txt)

