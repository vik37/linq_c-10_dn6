using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();
SamplesViewModelOrder vmo = new();
SamplesViewModelWhere vmw = new();
SamplesViewModelSingle vms = new();
SamplesViewModelPatritionDistinct vmpd = new();
SamplesViewModelContain vmc = new();
SamplesViewModelCompare vmcCompare = new();
SamplesViewModelUion vmu = new();
SamplesViewModelJoin vmj = new();
SamplesViewModelGrouping vmg = new();
SamplesViewModelAggregate vma = new();

// Call Sample Method
//var result = vm.GetAllQuery();
//var result = vm.GetAllMethod();
//var result = vm.GetSingleColumnQuery();
//var result = vm.GetSingleColumnMethod();
//var result = vm.GetSpecificColumnsQuery
//var result = vm.GetSpecificColumnsMethod();
//var result = vm.AnonymousClassQuery();
//var result = vm.AnonymousClassMethod();

//Call Order By Meyhods
//var result = vmo.OrderByQuery();
//var result = vmo.OrderByMethod();
//var result = vmo.OrderByDescendingQuery();
//var result = vmo.OrderByDescendingMethod();
//var result = vmo.OrderByTwoFieldsQuery();
//var result = vmo.OrderByTwoFieldsMethod();
//var result = vmo.OrderByTwoFieldsDescMethod();

//Call Methods with checks (where)
//var result = vmw.WhereQuery();
//var result = vmw.WhereMethod();
//var result = vmw.WhereTwoFieldsQuery();
//var result = vmw.WhereTwoFieldsMethod();
//var result = vmw.WhereExtensionQuery();
//var result = vmw.WhereExtensionMethod();

// Call Methods for Single Element
//var result = vms.FirstQuery();
//var result = vms.FirstMethod();
//var result = vms.FirstOrDefaultQuery();
//var result = vms.FirstOrDefaultMethod();
//var result = vms.SingleQuery();

// Call Patrition Distinct Methods
//var result = vmpd.TakeQuery();
//var result = vmpd.TakeMethod();
//var result = vmpd.TakeRangeQuery();
//var result = vmpd.TakeWhileQuery();
//var result = vmpd.TakeWhileMethod();
//var result = vmpd.SkipQuery();
//var result = vmpd.SkipMethod();
//var result = vmpd.SkipWhileQuery();
//var result = vmpd.DistinctQuery();
//var result = vmpd.DistinctByQuery();
//var result = vmpd.ChunkQuery();
//var result = vmpd.ChunkMethod();

// Call the Contain Methods
//var result = vmc.AllQuery();
//var result = vmc.AllMethod();
//var result = vmc.AllSalesQuery();
//var result = vmc.AllSalesMethod();
//var result = vmc.AnyQuery();
//var result = vmc.AnyMethod();
//var result = vmc.ContainsQuery();
//var result = vmc.ContainsMethod();
//var result = vmc.ContainsComparerQuery();

// Call the Compare Methods
//var result = vmcCompare.SequenceEqualIntegersQuery();
//var result = vmcCompare.SequenceEqualIntegersMethod();
//var result = vmcCompare.SequenceEqualObjectsQuery();
//var result = vmcCompare.SequenceEqualObjectsQuery();
//var result = vmcCompare.SequenceEqualUsingComparerQuery();
//var result = vmcCompare.SequenceEqualUsingComparerMethod();
//var result = vmcCompare.ExceptIntegersQuery();
//var result = vmcCompare.ExceptProductSalesQuery();
//var result = vmcCompare.ExceptProductSalesMethod();
//var result = vmcCompare.ExceptUsingComparerQuery();
//var result = vmcCompare.ExceptUsingComparerMethod();
//var result = vmcCompare.ExceptByQuery();
//var result = vmcCompare.ExceptByMethod();
//var result = vmcCompare.ExceptByProductSalesQuery();
//var result = vmcCompare.ExceptByProductSalesQuery();
//var result = vmcCompare.IntersectIntegersQuery();
//var result = vmcCompare.IntersectIntegersMethod();
//var result = vmcCompare.IntersectProductSalesQuery();
//var result = vmcCompare.IntersectProductSalesMethod();
//var result = vmcCompare.IntersectUsingComparerQuery();
//var result = vmcCompare.IntersectByQuery();
//var result = vmcCompare.IntersectByMethod();
//var result = vmcCompare.IntersectByProductSalesQuery();
//var result = vmcCompare.IntersectByProductSalesMethod();

// Call methods with Union Collection
//var result = vmu.UnionIntegersQuery();
//var result = vmu.UnionIntegersMethod();
//var result = vmu.UnionQuery();
//var result = vmu.UnionMethod();
//var result = vmu.UnionByQuery();
//var result = vmu.UnionByMethod();
//var result = vmu.ConcatIntegersMethod();
//var result = vmu.ConcatQuery();
//var result = vmu.ConcatMethod();

// Call method with Joins
//var result = vmj.InnerJoinQuery();
//var result = vmj.InnerJoinMethod();
//var result = vmj.InnerJoinTwoFieldsQuery();
//var result = vmj.InnerJoinTwoFieldsMethod();
//var result = vmj.JoinIntoQuery();
//var result = vmj.JoinIntoMethod();
//var result = vmj.LeftOuterJoinQuery();
//var result = vmj.LeftOuterJoinMethod();

// Call Grouping Method
//var result = vmg.GroupByQuery();
//var result = vmg.GroupByUsingKeyQuery();
//var result = vmg.GroupByWhereQuery();
//var result = vmg.GroupByWhereMethod();
//var result = vmg.GroupBySubQueryQuery();
//var result = vmg.GroupBySubQueryMethod();
//var result = vmg.GroupByDistinctQuery();

// Call Aggregate methods
var result = vma.CountQuery();
//var result = vma.CountMethod();
//var result = vma.CountFilteredQuery();
//var result = vma.CountFilteredMethod();
//var result = vma.MinQuery();
//var result = vma.MinMethod();
//var result = vma.MaxQuery();
//var result = vma.MaxMethod();
//var result = vma.MinByQuery();
//var result = vma.MinByMethod();
//var result = vma.MaxByQuery();
//var result = vma.MaxByMethod();
//var result = vma.AverageQuery();
//var result = vma.AverageMethod();
//var result = vma.SumQuery();
//var result = vma.SumMethod();
//var result = vma.AggregateQuery();
//var result = vma.AggregateMethod();
//var result = vma.AggregateCustomQuery();
//var result = vma.AggregateCustomMethod();
//var result = vma.AggregateUsingGroupByQuery();
//var result = vma.AggregateUsingGroupByMethod();
//var result = vma.AggregateMoreEfficientMethod();

// Display Results
vm.Display(result);