# Arquitetura Limpa

A arquitetura limpa coloca as regras de negócios e dos modelos no centro do aplicativo. Ao contrario da arquitetura de camadas que tem como fluxo de depedência regras de negócios dependendo da camada de acesso a dados, a arquitetura limpa utiliza a inversão de dependência, isso garante que o fluxo de depência entre a regra de negócio e de acesso a dados seja quebrada, garantindo assim, que as regras de négocios não  dependa das camada de acesso a dados, resultado em uma  camada de negócios isolada de depências desnecessarias.
