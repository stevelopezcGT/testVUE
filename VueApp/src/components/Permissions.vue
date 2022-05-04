<template>
    <div>
        <h3>Permissions</h3>
        <h1>{{ msg }}</h1>
    </div>
</template>

<script>
    export default {
        name: 'Permissions',
        props: {
            msg: String
        }
    };
</script>