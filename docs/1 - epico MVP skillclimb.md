# 📌 Epic 1 – Criação e Gestão de Trilhas de Estudo Personalizadas

## 🎯 Objetivo do Epic
Permitir que o usuário (Autodidata Organizado) crie e acompanhe trilhas de estudo personalizadas, organizando conteúdos e marcando seu progresso, substituindo o uso de ferramentas genéricas como planilhas, Notion ou listas soltas.

---

## 🧠 Dor do Usuário Atendida

| Dor | Impacto atual | Como o Epic resolve |
|-----|---------------|---------------------|
| Falta de organização dos materiais | Progresso mentalmente caótico, estudo desmotivador | Sistema visual de trilhas + etapas sequenciadas |
| Não consegue visualizar evolução | Não sabe “o quanto falta” | Barra de progresso por trilha |
| Métodos genéricos não ajudam | Planilhas não incentivam continuidade | UI feita para fluxo de estudo real, não genérico |
| Perde links, artigos e conteúdos | Não tem centralização | Etapas com links + tipo de conteúdo |
| Começa estudos e abandona | Sem senso de avanço | Marcação de concluído facilita retorno e retomada |

---

## ✅ Resultado Esperado
O usuário consegue:

1. Criar uma trilha com nome e descrição
2. Definir os conteúdos e etapas que irá estudar
3. Visualizar e acompanhar seu progresso
4. Marcar etapas como concluídas
5. Retornar ao app e continuar de onde parou
6. Ter todas as suas trilhas centralizadas em um único dashboard

---

## 🧩 Funcionalidades (Features do Epic)
| # | Feature | Descrição resumida |
|---|---------|--------------------|
| F1 | Criar trilha | Usuário define nome e descrição |
| F2 | Editar trilha | Usuário pode alterar nome, descrição, apagar |
| F3 | Adicionar etapas | Etapas com nome, tipo, links e ordem |
| F4 | Atualizar status da etapa | Marcar como concluída / não iniciada / em andamento |
| F5 | Barra de progresso da trilha | Cálculo automático baseado nas etapas concluídas |
| F6 | Dashboard de trilhas | Lista todas as trilhas criadas, com busca/ordenar |
| F7 | Visualizar trilha | Ver trilha completa com progresso e etapas |
| F8 | Persistência do estado do estudo | Ao logar novamente, progresso permanece salvo |

*(Obs: Features detalhadas em user stories no próximo passo)*

---

## 🔍 Critérios de Sucesso do Epic

✔ Usuário consegue criar ao menos 1 trilha do zero  
✔ Usuário consegue concluir 100% de uma trilha  
✔ Usuário entende visualmente sua evolução sem precisar de ajuda  
✔ Usuário consegue gerenciar mais de uma trilha ao mesmo tempo  
✔ Nenhuma trilha/perda de progresso após logout/login  
✔ MVP entregue **sem trilhas pré-definidas pela plataforma**  
✔ Nenhum elemento de gamificação ainda (somente progresso funcional)

---

## 🚫 Fora do Escopo deste Epic
| Tema | Motivo |
|------|--------|
| Gamificação (XP, badges, streaks) | pós MVP |
| Trilhas oficiais prontas (AZ-900 etc.) | depende de conteúdo externo |
| Compartilhar trilha com outros usuários | segunda fase |
| Dashboard com métricas globais | próximo epic |
| IA que gera trilhas automaticamente | evolução futura |
| Modo público / social de trilhas | pós validação do MVP |

---

## ⏳ Dependências
- Sistema de autenticação básico
- Armazenamento de dados de trilha e progresso
- Identificação de usuário (trilhas privadas por usuário)

---

## 🧪 Métricas para validar o valor do Epic
| Métrica | Indicador de sucesso |
|---------|---------------------|
| % de usuários que criam pelo menos 1 trilha | > 60% |
| % de usuários que retornam e marcam progresso | > 40% |
| % de trilhas com ao menos 3 etapas criadas | > 70% |
| % de trilhas concluídas (100%) | > 20% |

---
